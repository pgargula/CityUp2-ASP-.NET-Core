using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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

            return View();
        }
    }
}