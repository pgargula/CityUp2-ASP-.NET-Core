using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace PracaInzWebApplication.Controllers
{
    public class SharedController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
