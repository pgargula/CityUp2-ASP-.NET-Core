using System.Threading.Tasks;
using PracaInzWebApplication.Models;

namespace PracaInzWebApplication.Services.CityService
{
    public interface ICityService
    {
        Task<City> GetCity(int cityId);
    }
}