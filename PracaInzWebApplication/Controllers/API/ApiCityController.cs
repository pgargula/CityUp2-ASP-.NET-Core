using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Services.CityService;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracaInzWebApplication.Controllers.API
{
    [Route("api/[controller]")]
    public class ApiCityController : Controller
    {
        private readonly ICityService _cityService;
        public ApiCityController(ICityService cityService)
        {
            _cityService = cityService;
        }
        [HttpGet]
        public async Task<IEnumerable<City>> GetCities()
        {
            return await _cityService.GetCities();
        }
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<City> Get(int id)
        {
            return await _cityService.GetCity(id);
        }

    }
}
