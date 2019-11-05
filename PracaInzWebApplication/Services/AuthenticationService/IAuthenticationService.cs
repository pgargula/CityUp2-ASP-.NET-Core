using PracaInzWebApplication.Models;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.AuthenticationService
{
    public interface IAuthenticationService
    {
       public Task<string> GetToken(User user);
    }
}