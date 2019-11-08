using Microsoft.EntityFrameworkCore;
using PracaInzWebApplication.Data;
using PracaInzWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.ApplicationService
{
    public class ApplicationService : IApplicationService
    {
        private readonly AppDbContext _context;

        public ApplicationService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddApplication(Application application)
        {
            await _context.Applications.AddAsync(application);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteApplication(int applicationId)
        {
            var application = await _context.Applications.FindAsync(applicationId);
            _context.Applications.Remove(application);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Application>> GetAllByCity(int cityId)
        {
            return await _context.Applications.Include(x => x.Adress)
                 .Include(x => x.Adress.City)
                 .Include(x => x.Status)
                 .Include(x => x.AppplicationPictures)
                 .Include(x => x.User)
                 .Where(x => x.Adress.CityId == cityId).ToListAsync();
        }

        public async Task<IEnumerable<Application>> GetAllByUser(int userId)
        {
            return await _context.Applications.Include(x => x.Adress)
                 .Include(x => x.Adress.City)
                 .Include(x => x.Status)
                 .Include(x => x.AppplicationPictures)
                 .Include(x=>x.User)
                 .Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
