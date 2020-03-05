using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using PracaInzWebApplication.Models;

namespace PracaInzWebApplication.Services.CityService
{
    public interface ICityService
    {
        Task<IEnumerable<City>> GetCities();
        Task<City> GetCity(int cityId);
    }
}