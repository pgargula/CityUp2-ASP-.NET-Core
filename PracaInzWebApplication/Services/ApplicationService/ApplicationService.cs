using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PracaInzWebApplication.Data;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.ApplicationService
{
    public class ApplicationService : IApplicationService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ApplicationService(AppDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task AddApplication(Application application, IEnumerable<string> picurePaths)
        {

            await _context.Applications.AddAsync(application);
            await _context.SaveChangesAsync();
            List<ApplicationPicture> applicationPictures = new List<ApplicationPicture>();
            foreach(var picturePath in picurePaths)
            {
             applicationPictures.Add(new ApplicationPicture { ApplicationId = application.ApplicationId, PicturePath = picturePath });
            }

        }

        public async Task DeleteApplication(int applicationId)
        {
            var application = await _context.Applications.FindAsync(applicationId);
            _context.Applications.Remove(application);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Application>> GetAllByCity(int cityId)
        {
            try
            {
                return await _context.Applications.Include(x => x.Adress)
                     .Include(x => x.Adress.City)
                     .Include(x => x.Status)
                     .Include(x => x.AppplicationPictures)
                     .Include(x => x.User)
                     .Include(x => x.Category)
                     .Where(x => x.Adress.CityId == cityId).ToListAsync();  
            }
            catch(Exception ex)
            { 
                throw ex; 
            }

        }

        public async Task<ApplicationDetails> GetDetails(int applicationId)
        {
            try
            {
                var appDetails = await _context.Applications
                         .Include(x => x.Adress.City)
                         .Include(x => x.Adress)
                         .Include(x => x.Status)
                         .Include(x => x.AppplicationPictures)
                         .Include(x => x.User)
                         .Include(x => x.Category)
                         .Where(x => x.ApplicationId == applicationId).FirstOrDefaultAsync();
                //var tmp = _mapper.Map<ApplicationDetails>(appDetails);
                if (appDetails != null)
                {
                    return new ApplicationDetails()
                    {
                        Title = appDetails.Title,
                        Category = appDetails.Category.Name,
                        City = appDetails.Adress.City.Name,
                        Description = appDetails.Description,
                       // District = appDetails.Adress.District.Name,
                        Pictures = appDetails.AppplicationPictures.ToList(),
                        Status = appDetails.Status.Label,
                        Street = appDetails.Adress.Street,
                        User = appDetails.User.Login
                    };
                }
                else
                {
                    return null;
                }
                //return tmp;
            }
            catch(Exception ex)
            {
                throw ex;
            }
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
