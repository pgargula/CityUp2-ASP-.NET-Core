using System.Collections.Generic;
using System.Threading.Tasks;
using PracaInzWebApplication.Models;

namespace PracaInzWebApplication.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}