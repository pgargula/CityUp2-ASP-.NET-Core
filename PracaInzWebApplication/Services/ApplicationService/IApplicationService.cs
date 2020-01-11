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
        Task AddPhotos(List<IFormFile> photos, int applicationId);
        Task AddVote(int applicationId, int userId);
        Task ChangeAdminMsg(int applicationId, string adminMsg);
        Task ChangeStatus(int applicationId, int statusId);
        Task DeleteApplication(int applicationId);
        Task DeleteVote(int applicationId, int userId);
        Task<IEnumerable<Application>> GetAllByCity(int cityId);
        Task<IEnumerable<Application>> GetAllByUser(int userId);
        Task<ApplicationDetails> GetDetails(int applicationId);
        Task<ScoreViewModel> GetScore(int applicationId, int userId);
        Task<IEnumerable<Status>> GetStatuses();
        Task<bool> IsUserApp(int applicationId, int userId);
    }
}