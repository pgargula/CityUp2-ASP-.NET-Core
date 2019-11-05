using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using PracaInzWebApplication.Helpers;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Models.DTO;
using PracaInzWebApplication.Services.AuthenticationService;
using PracaInzWebApplication.Services.UserService;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.UserService
{
    public class MockUserService : IUserService
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IMapper _mapper;
        private List<User> _userList = new List<User>
        {
            new User(){Id=1, Login="admin", Password="admin", Email="admin@test.pl",City = 1, Role=Roles.SystemAdministrator},
            new User(){Id=1, Login="user", Password="user", Email="user@test.pl",City = 1, Role=Roles.User},
            new User(){Id=1, Login="cityadmin", Password="cityadmin", Email="cityadmin@test.pl",City = 1, Role=Roles.CityAdministrator}
        };

        public MockUserService(IAuthenticationService authenticationService, IMapper mapper)
        {
            _authenticationService = authenticationService;
            _mapper = mapper;
        }

        public async Task<string> LoginUser(string login, string password)
        {
            User user = _userList.SingleOrDefault(x => x.Login == login);

            if (user == null)
                return null;
            if (user.Password == password)
            {
              return await _authenticationService.GetToken(user);
            }
            else
                return null;
           
        }

        public async Task<string> RegisterUser(UserRegisterDTO userRegisterDTO )
        {
            try
            {
                var user = _userList.SingleOrDefault(x => x.Login == userRegisterDTO.Login);
                if (user == null)
                {
                    var userToAdd = _mapper.Map<User>(userRegisterDTO);
                    userToAdd.Role = Roles.User;
                    _userList.Add(userToAdd);
                    return "OK";
                }
                else
                    return "Login zajęty";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
