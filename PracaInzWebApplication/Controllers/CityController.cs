using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracaInzWebApplication.CustomAtributes;
using PracaInzWebApplication.Helpers;

namespace PracaInzWebApplication.Controllers
{
    [Authorize]
    public class CityController : Controller
    {
        [Authorize(Roles.CityAdministrator, Roles.CityModerator)]
        public IActionResult SubCityApplications()
        {
            return View();
        }
        [Authorize(Roles.CityAdministrator)]
        public IActionResult CityApplications()
        {
            return View();
        }
        [Authorize(Roles.CityAdministrator)]
        public IActionResult Stats()
        {
            return View();
        }
        [Authorize(Roles.CityAdministrator, Roles.CityModerator )]
        public IActionResult SubCityStats()
        {
            return View();
        }
        [Authorize(Roles.CityAdministrator)]
        public IActionResult Moderate()
        {
            return View();
        }
    }
}