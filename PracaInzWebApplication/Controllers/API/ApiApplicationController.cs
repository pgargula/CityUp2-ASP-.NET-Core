using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Services.ApplicationService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracaInzWebApplication.Controllers.API
{
    [Route("api/[controller]/[action]")]
    public class ApiApplicationController : Controller
    {
        private readonly IApplicationService _applicationService;
       
        public ApiApplicationController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }


        // GET: api/ApiApplication/userId
        [HttpGet("{userId}")]
        public async Task<IEnumerable<Application>> GetAllByUser(int userId)
        {
            return await _applicationService.GetAllByUser(userId);
        }

        // GET: api/ApiApplication/cityId
        [HttpGet("{cityId}")]
        public async Task<IEnumerable<Application>> GetAllByCity(int cityId)
        {
            return await _applicationService.GetAllByCity(cityId);
        }

        // POST api/ApiApplication
        [HttpPost]
        public async Task Add([FromBody]Application application)
        {
           await _applicationService.AddApplication(application);
        }


        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _applicationService.DeleteApplication(id);
        }
    }
}
