using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using PracaInzWebApplication.Data;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.ApplicationService
{
    public class ApplicationService : IApplicationService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hostEnvironment;
        public ApplicationService(AppDbContext context, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _mapper = mapper;
            _context = context;
            _hostEnvironment = webHostEnvironment;
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
                     .Include(x => x.Adress.Geolocation)
                     .Include(x => x.Status)
                     .Include(x => x.ApplicationPictures)
                     .Include(x => x.User)
                     .Include(x => x.Category)
                     .Where(x => x.Adress.CityId == cityId).ToListAsync();
            }
            catch (Exception ex)
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
                         .Include(x => x.ApplicationPictures)
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
                        Pictures = appDetails.ApplicationPictures.ToList(),
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Application>> GetAllByUser(int userId)
        {
            return await _context.Applications.Include(x => x.Adress)
                 .Include(x => x.Adress.City)
                 .Include(x => x.Status)
                 .Include(x => x.ApplicationPictures)
                 .Include(x => x.User)
                 .Where(x => x.UserId == userId).ToListAsync();
        }
        public async Task<int> AddApplication(AddApplication applicationDto)
        {

            Application application;
            try
            {
                Geolocation geolocation = new Geolocation { Latitude = applicationDto.Latitude, Longitude = applicationDto.Longitude };
                await _context.Geolocations.AddAsync(geolocation);
                await _context.SaveChangesAsync();
                Adress adress = new Adress { CityId = applicationDto.CityId, Street = applicationDto.Street, GeolocationId = geolocation.GeolocationId };
                await _context.Adresses.AddAsync(adress);
                await _context.SaveChangesAsync();
                application = _mapper.Map<AddApplication, Application>(applicationDto);
                application.AdressId = adress.AdressId;
                application.StatusId = 1;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            try
            {
                await _context.Applications.AddAsync(application);
                await _context.SaveChangesAsync();
                return application.ApplicationId;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task AddPhotos(List<IFormFile> photos, int applicationId)
        {
            List<string> picturePaths = new List<string>();
            Random rnd = new Random();
            if (photos != null)
            {
                try
                {
                    foreach (var photo in photos)
                    {
                        string shortPicturePath = "/applications_pictures /" + DateTime.Now.Ticks + photo.FileName ;
                        string PicturePath = _hostEnvironment.WebRootPath + shortPicturePath.Replace('/', '\\');

                        picturePaths.Add(shortPicturePath);

                        using (var stream = new FileStream(PicturePath, FileMode.Create))
                        {
                            await photo.CopyToAsync(stream);
                        }
                    }
                    foreach (var path in picturePaths)
                    {
                        _context.ApplicationPictures.Add(new ApplicationPicture { ApplicationId = applicationId, PicturePath = path });
                    }
                    await _context.SaveChangesAsync();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            
        }
    }

}


                
            
        
    

