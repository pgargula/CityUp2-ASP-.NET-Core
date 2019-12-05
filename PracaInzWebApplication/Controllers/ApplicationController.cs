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
        [Authorize(Roles.User)]
        [HttpGet]
        public async Task<IActionResult> AddNew()
        {
            return View();
        }

        [Authorize(Roles.User)]
        [HttpPost]
        public async Task<IActionResult> AddNew(AddApplication addApplication)
        {
            addApplication.UserId =Convert.ToInt32(User.Claims.Where(x => x.Type == "Id").FirstOrDefault().Value);
            var photos = addApplication.Photos;
            addApplication.Photos = null;
            var uri = new Uri(Consts.appAdress + "api/ApiApplication/Add");
            var uriPhoto = new Uri(Consts.appAdress + "api/ApiApplication/AddPhotos/");
            //try
            //{
            //    using (HttpClient _httpClient = new HttpClient())
            //    {
            //        var requestBody = new StringContent(JsonConvert.SerializeObject(addApplication), Encoding.UTF8, "application/json");
            //        var response = await _httpClient.PostAsync(uri, requestBody);
            //        if (response.StatusCode == HttpStatusCode.OK)
            //        {                    
            //            var multipartFormDataContent = new MultipartFormDataContent();
            //            //foreach (var photo in photos)
            //            //{
            //                var fileStream = photos.OpenReadStream();

            //                multipartFormDataContent.Add(new StreamContent(fileStream), "file", photos.FileName);

            //           // }
            //            var responsePhoto = await _httpClient.PostAsync(uriPhoto, multipartFormDataContent);

            //            if (responsePhoto.StatusCode == HttpStatusCode.OK)
            //            {
            //                ViewBag.JavaScriptToRun = " showSnackbar()";
            //                return View();
            //            }
            //            else
            //                return null;
            //        }
            //        else
            //            return null;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw new WebException("Nie udało sie dodać zgłoszenia!");
            //}
            
            using (var httpClient = new HttpClient())
            {
                var requestBody = new StringContent(JsonConvert.SerializeObject(addApplication), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(uri, requestBody);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var applicationId = response.Content.ReadAsStringAsync();
                    var form = new MultipartFormDataContent();
                    foreach (var photo in photos)
                    {
                        var fileStream = photo.OpenReadStream();
                        form.Add(new StreamContent(fileStream), "file", photo.FileName);
                    }
                    
                    var responsePhoto = await httpClient.PostAsync(uriPhoto+applicationId.Result, form);
                    if (responsePhoto.StatusCode == HttpStatusCode.OK)
                    {

                    }                 
                }

            }
            return View();
        }
    }
}