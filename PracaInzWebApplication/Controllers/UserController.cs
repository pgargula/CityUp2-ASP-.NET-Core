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
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Login(UserLoginDTO userLoginDTO)   
        {        
                var uri = new Uri(Consts.appAdress + "api/User/LoginUser");
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

        public IActionResult Logoff()
        {
            HttpContext.Session.Clear();
            return Redirect("~/Home/Index");
        }

    }
}
