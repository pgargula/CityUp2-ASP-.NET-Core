using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Services.CategoryService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracaInzWebApplication.Controllers.API
{
    [Route("api/[controller]")]
    public class ApiCategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public ApiCategoryController(ICategoryService service)
        {
            _categoryService = service;
        }
        // Get api/ApiApplication
        [HttpGet]
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _categoryService.GetCategories();
        }

    }
}
