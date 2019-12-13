using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PracaInzWebApplication.CustomAtributes;
using PracaInzWebApplication.Helpers;
using PracaInzWebApplication.Models.ViewModels;

namespace PracaInzWebApplication.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly IMapper _mapper;
        private readonly HttpClient _httpClient = new HttpClient();
        public ApplicationController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [Authorize]
        public IActionResult UserApplications()
        {
            return View();
        }
        [Authorize]
        public async Task<IActionResult> ApplicationsMap()
        {
            return View();
        }
        [Authorize]
        public async Task<IActionResult> ApplicationDetails(int applicationId)
        {
            ///check isuserapp
            ViewBag.ApplicationId = applicationId;
            var userId = User.Claims.FirstOrDefault(x => x.Type == "Id").Value;
            var uriIsUserApp = new Uri(Consts.appAdress + "api/ApiApplication/IsUserApp/" + applicationId + "/" + userId);
            try
            {
                var response = await _httpClient.GetAsync(uriIsUserApp);
                var resultContent = Convert.ToBoolean(await response.Content.ReadAsStringAsync());
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (resultContent)
                    {
                        ViewBag.IsUserApp = "userApp";
                    }
                }
                else
                    Redirect("~/Home/Index");

                /// dowload application details
                var uri = new Uri(Consts.appAdress + "api/ApiApplication/GetDetails/" + applicationId);
           
                using (HttpClient _httpClient = new HttpClient())
                {
                    var responseDetails = await _httpClient.GetAsync(uri);
                    if (responseDetails.StatusCode == HttpStatusCode.OK)
                    {
                        ApplicationDetails model= JsonConvert.DeserializeObject<ApplicationDetails>(await responseDetails.Content.ReadAsStringAsync());
                        return View(model);
                    }
                    else
                        return View();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        [Authorize(Roles.User)]
        [HttpGet]
        public async Task<IActionResult> AddNew()
        {
            return View();
        }
        [Authorize]
        public async Task<IActionResult> AllApplication()
        {
            return View();
        }

        [Authorize(Roles.User)]
        [HttpPost]
        public async Task<IActionResult> AddNew(AddApplication addApplication)
        {
            addApplication.UserId = Convert.ToInt32(User.Claims.Where(x => x.Type == "Id").FirstOrDefault().Value);
            var photos = addApplication.Photos;
            addApplication.Photos = null;
            var uri = new Uri(Consts.appAdress + "api/ApiApplication/Add");
            var uriPhoto = new Uri(Consts.appAdress + "api/ApiApplication/AddPhotos/");
            HttpResponseMessage responsePhoto;

            using (var httpClient = new HttpClient())
            {
                if (ModelState.IsValid)
                {
                    var requestBody = new StringContent(JsonConvert.SerializeObject(addApplication), Encoding.UTF8, "application/json");
                    var response = await _httpClient.PostAsync(uri, requestBody);
                    HttpContent noPhoto = new StringContent("noPhoto", Encoding.UTF8, "application/json");
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var applicationId = response.Content.ReadAsStringAsync();
                        var form = new MultipartFormDataContent();
                        if (photos != null)
                        {
                            foreach (var photo in photos)
                            {
                                var fileStream = photo.OpenReadStream();
                                form.Add(new StreamContent(fileStream), "file", photo.FileName);
                            }
                            responsePhoto = await httpClient.PostAsync(uriPhoto + applicationId.Result, form);


                        }
                        else
                        {
                            responsePhoto = await httpClient.PostAsync(uriPhoto + applicationId.Result, noPhoto);
                        }
                        
                        if (responsePhoto.StatusCode == HttpStatusCode.OK)
                        {
                            ViewBag.JavaScriptToRun = "AddNotification(function () { window.location.href = '/Application/AddNew';}, 'Pomyślnie dodano zgłoszenie'); ";
                            return View();
                        }
                        else
                        {
                            return View();
                        }
                        //else
                        //    ViewBag.JavaScriptToRun = "itemAddNotification(function () { window.location.href = '/Application/AddNew';}); ";
                        //    return View();
                    }

                }
                return View();
            }
        }
    }
}