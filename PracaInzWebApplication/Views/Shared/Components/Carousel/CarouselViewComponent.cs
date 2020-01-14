using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Views.Shared.Components.Carousel
{
    public class CarouselViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(int applicationId)
        {          
            return View("CarouselView");
        }
    }
}
