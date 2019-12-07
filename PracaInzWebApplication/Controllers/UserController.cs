using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PracaInzWebApplication.CustomAtributes;
using PracaInzWebApplication.Helpers;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Models.DTO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracaInzWebApplication.Controllers
{  
    public class UserController : Controller
    {
        private HttpClient _httpClient = new HttpClient();
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [Authorize]
        [HttpGet]
        public IActionResult MyProfile()
        {
            return View();
        }
        [Authorize(Roles.User)]
        public IActionResult UserApplications()
        {
            return View();
        }
        public async Task<IActionResult> ApplicationDetails(int applicationId)
        {
            ViewBag.ApplicationId = applicationId;
            var userId = User.Claims.FirstOrDefault(x => x.Type == "Id").Value;
            var uri = new Uri(Consts.appAdress + "api/ApiApplication/IsUserApp/" + applicationId + "/" + userId );
            try
            {
                var response = await _httpClient.GetAsync(uri);
                var resultContent =  Convert.ToBoolean(await response.Content.ReadAsStringAsync());
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (resultContent)
                    {
                        ViewBag.IsUserApp = "userApp";
                    }
                }
                else
                    Redirect("~/Home/Index");

            }
            catch(Exception ex)
            {
                //Redirect("~/Home/Index");
                throw ex;
            }
            
            return View();
        }


        [HttpPost]
        public async Task <IActionResult> Login(UserLoginDTO userLoginDTO)   
        {        
                var uri = new Uri(Consts.appAdress + "api/ApiUser/LoginUser");
                try
                {
                    var requestBody = new StringContent(JsonConvert.SerializeObject(userLoginDTO),Encoding.UTF8, "application/json");
                    var response = await _httpClient.PostAsync(uri, requestBody);
                    var resultContent = await response.Content.ReadAsStringAsync();
                 
                    if (response.StatusCode == HttpStatusCode.OK)
                    {  
                      //var token = JsonConvert.DeserializeObject<string>(resultContent);
                        if (resultContent != null)
                            {
                                //Save token in session object
                                HttpContext.Session.SetString("JWToken", resultContent);
                      
                            return Redirect("~/Home/Index");
                            
                            }
                    }
                    ModelState.AddModelError(string.Empty, "Nieudana próba logowania");
                 }
                catch (Exception e)
                {
                    throw new WebException("Nie udało sie zalogować");
                }

            return View(userLoginDTO);
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterDTO userRegisterDTO)
        {
            UserLoginDTO userLoginDTO = new UserLoginDTO() {Login=userRegisterDTO.Login,Password=userRegisterDTO.Password};
            var uri = new Uri(Consts.appAdress + "api/ApiUser/RegisterUser");
            try 
            { 
                var requestBody = new StringContent(JsonConvert.SerializeObject(userRegisterDTO), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(uri, requestBody);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var resultContent = await response.Content.ReadAsStringAsync();
                    if (resultContent=="OK")
                        return await Login(userLoginDTO);
                    else
                        ModelState.AddModelError(string.Empty, "Login zajęty");
                }
                ModelState.AddModelError(string.Empty, "Nieudana próba rejestracji");
            }
            catch (Exception e)
            {
                throw new WebException("Nie udało sie zarejestrować");
            }
            return View(userRegisterDTO);
        }
       
        [Authorize]
        public IActionResult Logoff()
        {
            HttpContext.Session.Clear();
            return Redirect("~/Home/Index");
        }

    }
}
