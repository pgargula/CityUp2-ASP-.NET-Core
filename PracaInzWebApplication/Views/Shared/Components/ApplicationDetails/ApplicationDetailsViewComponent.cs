using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PracaInzWebApplication.Helpers;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Views.Shared.Components
{
    public class ApplicationDetailsViewComponent : ViewComponent
    {
        private ApplicationDetails _applicationDetails;        
        public async Task<ApplicationDetails> GetDetails(int applicationId)
        {
            var uri = new Uri(Consts.appAdress + "api/ApiApplication/GetDetails/"+applicationId);
            try
            {
                using (HttpClient _httpClient = new HttpClient())
                {
                    var response = await _httpClient.GetAsync(uri);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        return JsonConvert.DeserializeObject<ApplicationDetails>(await response.Content.ReadAsStringAsync());
                    }
                    else
                        return null;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
        public async Task<IViewComponentResult> InvokeAsync(int applicationId)
        {
            _applicationDetails =await GetDetails(applicationId);
            ViewBag.ApplicationId = applicationId;
            return View("Details",_applicationDetails);
        }
    }
}
