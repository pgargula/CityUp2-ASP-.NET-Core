using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracaInzWebApplication.Controllers
{
    public class CommentController : Controller
    {
        // GET: /<controller>/
     [HttpGet]
     public async Task<IActionResult> CommentView(int applicationId)
        {
            return ViewComponent("Comment",applicationId);
        }
    }
}
