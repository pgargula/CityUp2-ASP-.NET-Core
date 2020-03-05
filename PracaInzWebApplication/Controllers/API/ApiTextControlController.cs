using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracaInzWebApplication.Services.TextControlService;



namespace PracaInzWebApplication.Controllers.API
{
    [Route("api/[controller]")]
    public class ApiTextControlController : Controller
    {
        private readonly ITextControlService _textControlService;
        public ApiTextControlController(ITextControlService textControlService)
        {
            _textControlService = textControlService;
        }
        // GET: api/<controller>
        [HttpPost]
        public async Task<int> GetHint([FromForm]string text)
        {
            return await _textControlService.CategoryHint(text);
        }

        
    }
}
