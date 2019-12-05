using Microsoft.EntityFrameworkCore;
using PracaInzWebApplication.Data;
using PracaInzWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.CityService
{
    public class CityService : ICityService
    {
        private readonly AppDbContext _context;
        public CityService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<City> GetCity(int cityId)
        {
            try
            {
                return await _context.Cities
                    .Include(x => x.Geolocation)
                    .Where(x => x.CityId == cityId)
                    .FirstOrDefaultAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<City>> GetCities()
        {
            try
            {
                return await _context.Cities
                    .Include(x=>x.Geolocation)
                    .ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
