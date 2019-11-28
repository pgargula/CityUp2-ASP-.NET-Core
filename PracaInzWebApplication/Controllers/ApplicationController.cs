using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracaInzWebApplication.CustomAtributes;

namespace PracaInzWebApplication.Controllers
{
    public class ApplicationController : Controller
    {
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
    }
}