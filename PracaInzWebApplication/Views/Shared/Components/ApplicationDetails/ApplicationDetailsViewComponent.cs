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
        //public static list<applicationpicture> pp = new list<applicationpicture>
        //{
        //   new applicationpicture { applicationpictureid = 1, picturepath = "https://mpi.krakow.pl/zalacznik/320782/4.jpg", applicationid = 1 },
        //   new applicationpicture { applicationpictureid = 2, picturepath = "https://fajnepodroze.pl/wp-content/uploads/2018/01/krakow.jpg", applicationid = 2 },
        //   new applicationpicture { applicationpictureid = 3, picturepath = "https://czasnawywczas.pl/wp-content/uploads/krakow-budynki.jpg", applicationid = 2 },
        //   new applicationpicture { applicationpictureid = 4, picturepath = "https://czasnawywczas.pl/wp-content/uploads/krakow-runek-glowa.jpg", applicationid = 3 }
        //};
        //private applicationdetails aa = new applicationdetails { title = "weq", description = "dasd", category = "adasd", district = "district", city = "krakow", status = "wtrakcie", street = "dsa", user = "user", pictures=pp};
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
            return View("Details",_applicationDetails);
        }
    }
}
