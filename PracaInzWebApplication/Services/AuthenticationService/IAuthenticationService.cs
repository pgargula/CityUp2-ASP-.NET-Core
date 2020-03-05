using System.Threading.Tasks;
using PracaInzWebApplication.Models;

namespace PracaInzWebApplication.Services.AuthenticationService
{
    public interface IAuthenticationService
    {
        Task<string> GetToken(User user);
        string HashPassword(string password, out string salt);
        bool VerifyPassword(string password, string hashPassword, string salt);
    }
}