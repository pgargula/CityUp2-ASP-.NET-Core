using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Models.ViewModels;

namespace PracaInzWebApplication.Services.ApplicationService
{
    public interface IApplicationService
    {
        Task<int> AddApplication(AddApplication applicationDto);
        Task DeleteApplication(int applicationId);
        Task<IEnumerable<Application>> GetAllByCity(int cityId);
        Task<IEnumerable<Application>> GetAllByUser(int userId);
        Task<ApplicationDetails> GetDetails(int applicationId);
        Task AddPhotos(List<IFormFile> photos, int applicationId);
    }
}