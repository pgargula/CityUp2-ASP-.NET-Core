using PracaInzWebApplication.Models;
using PracaInzWebApplication.Models.DTO;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.UserService
{
   public interface IUserService
    {
        public Task<string> LoginUser(string login, string password);
        public Task<string> RegisterUser(UserRegisterDTO userRegisterDTO);
    }
}
