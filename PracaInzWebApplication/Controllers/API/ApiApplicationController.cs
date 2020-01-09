using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Models.ViewModels;
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
        // GET: api/ApiApplication/applkicationId
        [HttpGet("{applicationId}")]
        public async Task<ApplicationDetails> GetDetails(int applicationId)
        {
            return await _applicationService.GetDetails(applicationId);
        }

        [HttpGet("{applicationId}/{userId}")]
        public async Task<bool> IsUserApp(int applicationId, int userId)
        {
            return await _applicationService.IsUserApp(applicationId, userId);
        }

        [HttpGet("{applicationId}/{userId}")]
        public async Task<ScoreViewModel> GetScore(int applicationId, int userId)
        {
            return await _applicationService.GetScore(applicationId, userId);
        }
        [HttpPost]
        public async Task AddVote([FromForm]int applicationId, [FromForm]int userId)
        {
             await _applicationService.AddVote(applicationId,userId);
        }
        [HttpPost]
        public async Task DeleteVote([FromForm]int applicationId, [FromForm]int userId)
        {
             await _applicationService.DeleteVote(applicationId, userId);
        }

        // POST api/ApiApplication
        [HttpPost]
        public async Task<int> Add([FromBody]AddApplication application)
        {
            return await _applicationService.AddApplication(application);
        }

        [HttpPost("{applicationId}")]
        public async Task AddPhotos([FromForm] List<IFormFile> file,int applicationId)
        {

            await _applicationService.AddPhotos(file, applicationId);
        }




        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _applicationService.DeleteApplication(id);
        }


    }
}
