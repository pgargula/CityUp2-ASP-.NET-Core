using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        private IWebHostEnvironment _hostingEnvironment;

        public ApiApplicationController(IApplicationService applicationService,IWebHostEnvironment webHostEnvironment)
        {
            _applicationService = applicationService;
            _hostingEnvironment = webHostEnvironment;
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
            var dasd =await _applicationService.GetAllByCity(cityId);
            return dasd;
        }

        // POST api/ApiApplication
        [HttpPost]
        public async Task Add([FromBody]Application application, IFormFile pictures)
        {
            List<string> picturePaths = new List<string>();
            //todo : multiple pictures
            if (pictures != null /*&& files.Count > 0*/)
            {
                if (pictures.Length > 0)
                {
                    string shortPicturePath = "/applications_pictures/" + application.ApplicationId + "/" + pictures.FileName;
                    string PicturePath = _hostingEnvironment.WebRootPath + shortPicturePath.Replace('/', '\\');

                    picturePaths.Add(shortPicturePath);

                    using (var stream = new FileStream(PicturePath, FileMode.Create))
                    {
                        await pictures.CopyToAsync(stream);
                    }
                }
                //}
            }
            await _applicationService.AddApplication(application, picturePaths);
        }


        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _applicationService.DeleteApplication(id);
        }
    }
}
