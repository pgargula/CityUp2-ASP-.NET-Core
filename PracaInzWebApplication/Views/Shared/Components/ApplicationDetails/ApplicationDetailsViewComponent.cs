using Microsoft.AspNetCore.Mvc;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Views.Shared.Components
{
    public class ApplicationDetailsViewComponent : ViewComponent
    {
        public static List<ApplicationPicture> pp = new List<ApplicationPicture>
        {
           new ApplicationPicture { ApplicationPictureId = 1, PicturePath = "https://mpi.krakow.pl/zalacznik/320782/4.jpg", ApplicationId = 1 },
           new ApplicationPicture { ApplicationPictureId = 2, PicturePath = "https://fajnepodroze.pl/wp-content/uploads/2018/01/krakow.jpg", ApplicationId = 2 },
           new ApplicationPicture { ApplicationPictureId = 3, PicturePath = "https://czasnawywczas.pl/wp-content/uploads/krakow-budynki.jpg", ApplicationId = 2 },
           new ApplicationPicture { ApplicationPictureId = 4, PicturePath = "https://czasnawywczas.pl/wp-content/uploads/krakow-runek-glowa.jpg", ApplicationId = 3 }
        };
        private ApplicationDetails aa = new ApplicationDetails { Title = "weq", Description = "dasd", Category = "adasd", District = "District", City = "krakow", Status = "wtrakcie", Street = "dsa", User = "user", Pictures=pp};
        public async Task<IViewComponentResult> InvokeAsync(int applicationId)
        {
            return View("Details",aa);
        }
    }
}
