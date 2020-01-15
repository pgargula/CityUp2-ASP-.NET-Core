using System.Threading.Tasks;
using PracaInzWebApplication.Models.DTO;
using PracaInzWebApplication.Models.ViewModels;

namespace PracaInzWebApplication.Services.UserService
{
    public interface IUserService
    {
        Task<UserDetails> GetUserDetails(int userId);
        Task<string> LoginUser(string login, string password);
        Task<string> RegisterUser(UserRegisterDTO userRegisterDTO);
    }
}