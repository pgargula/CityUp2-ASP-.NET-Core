﻿using System.Collections.Generic;
using System.Threading.Tasks;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Models.ViewModels;

namespace PracaInzWebApplication.Services.ApplicationService
{
    public interface IApplicationService
    {
        Task AddApplication(Application application, IEnumerable<string> picturePaths);
        Task DeleteApplication(int applicationId);
        Task<IEnumerable<Application>> GetAllByCity(int cityId);
        Task<IEnumerable<Application>> GetAllByUser(int userId);
        Task<ApplicationDetails> GetDetails(int applicationId);
    }
}