using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracaInzWebApplication.Models.DTO;
using PracaInzWebApplication.Services;
using PracaInzWebApplication.Services.UserService;

namespace PracaInzWebApplication.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // POST: api/User
        [HttpPost]   
        [Route("LoginUser")]
        public async Task<string> LoginUser(UserLoginDTO userLoginDTO)
        {
            try
            {
                return await _userService.LoginUser(userLoginDTO.Login, userLoginDTO.Password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("RegisterUser")]
        public async Task<string> RegisterUser(UserRegisterDTO userRegisterDTO)
        {
            try 
            {
                return await _userService.RegisterUser(userRegisterDTO);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


    }
}
