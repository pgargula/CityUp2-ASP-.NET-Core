using System.Collections.Generic;
using System.Threading.Tasks;
using PracaInzWebApplication.Models;

namespace PracaInzWebApplication.Services.ApplicationService
{
    public interface IApplicationService
    {
        Task AddApplication(Application application);
        Task DeleteApplication(int applicationId);
        Task<IEnumerable<Application>> GetAllByCity(int cityId);
        Task<IEnumerable<Application>> GetAllByUser(int userId);
    }
}