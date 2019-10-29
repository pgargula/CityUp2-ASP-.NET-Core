using PracaInzWebApplication.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services
{
    interface IUserService
    {
        public JwtSecurityToken LoginUser(string login, string password);
    }
}
