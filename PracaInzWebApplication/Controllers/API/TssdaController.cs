using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracaInzWebApplication.CustomAtributes;
using PracaInzWebApplication.Helpers;

namespace PracaInzWebApplication.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TssdaController : ControllerBase
    {
        [Authorize]
        // GET: api/Tssda
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [Authorize(Roles.CityAdministrator)]
        // GET: api/Tssda/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tssda
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Tssda/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
