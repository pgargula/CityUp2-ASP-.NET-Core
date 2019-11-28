using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PracaInzWebApplication.Data;
using PracaInzWebApplication.Helpers;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Models.DTO;
using PracaInzWebApplication.Services.AuthenticationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.UserService
{
    public class UserService :IUserService
    { 
        private readonly IAuthenticationService _authenticationService;
        private readonly IMapper _mapper;
        private AppDbContext _dbContext;

        public UserService(IAuthenticationService authenticationService, IMapper mapper, AppDbContext dbContext)
        {
            _authenticationService = authenticationService;
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<string> LoginUser(string login, string password)
        {
            User user = _dbContext.Users.SingleOrDefault(x => x.Login == login);

            if (user == null)
                return null;
            if (user.Password == password)
            {
                return await _authenticationService.GetToken(user);
            }
            else
                return null;

        }

        public async Task<string> RegisterUser(UserRegisterDTO userRegisterDTO)
        {
            try
            {
                var user = await _dbContext.Users.SingleOrDefaultAsync(x => x.Login == userRegisterDTO.Login);
                if (user == null)
                {
                    var userToAdd = _mapper.Map<User>(userRegisterDTO);
                    userToAdd.Role = Roles.User;
                    await _dbContext.Users.AddAsync(userToAdd);
                    await _dbContext.SaveChangesAsync();
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
