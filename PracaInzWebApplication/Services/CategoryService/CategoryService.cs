using Microsoft.EntityFrameworkCore;
using PracaInzWebApplication.Data;
using PracaInzWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            try
            {
                return await _context.Categories.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
