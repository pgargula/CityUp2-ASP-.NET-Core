using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PracaInzWebApplication.Data;
using PracaInzWebApplication.Helpers;
using PracaInzWebApplication.Models;
using PracaInzWebApplication.Models.DTO;
using PracaInzWebApplication.Models.ViewModels;
using PracaInzWebApplication.Services.AuthenticationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.UserService
{
    public class UserService : IUserService
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
            User user = await _dbContext.Users
                .Include(x => x.City)
                .SingleOrDefaultAsync(x => x.Login == login);

            if (user == null)
                return null;
            if (_authenticationService.VerifyPassword(password, user.Password, user.Salt))
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
                    string salt;
                    userRegisterDTO.Password = _authenticationService.HashPassword(userRegisterDTO.Password, out salt);
                    var userToAdd = _mapper.Map<User>(userRegisterDTO);
                    userToAdd.Role = Roles.User;
                    userToAdd.Salt = salt;
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


        public async Task<UserDetails> GetUserDetails(int userId)
        {
            UserDetails userDetails = new UserDetails();
            User userTmp = await _dbContext.Users.Include(x => x.City).FirstOrDefaultAsync(x => x.UserId == userId);
            userDetails.Login = userTmp.Login;
            userDetails.Email = userTmp.Email;
            userDetails.City = userTmp.City.Name;
            var userApp = await _dbContext.Applications.Where(x => x.UserId == userId).ToListAsync();
            userDetails.AppNumber = userApp.Count();
            var damApp = await _dbContext.Applications.Include(x => x.Category).Where(x => x.Category.CategoryId == 3 && x.UserId == userId).ToListAsync();
            userDetails.DamageAppNumber = damApp.Count();
            var danApp = await _dbContext.Applications.Include(x => x.Category).Where(x => x.Category.CategoryId == 2 && x.UserId == userId).ToListAsync();
            userDetails.DangerAppNumber = danApp.Count();
            var dirApp = await _dbContext.Applications.Include(x => x.Category).Where(x => x.Category.CategoryId == 1 && x.UserId == userId).ToListAsync();
            userDetails.DirtAppNumber = dirApp.Count();
            var iniApp = await _dbContext.Applications.Include(x => x.Category).Where(x => x.Category.CategoryId == 4 && x.UserId == userId).ToListAsync();
            userDetails.InitiativeAppnumber = iniApp.Count();
            var othApp = await _dbContext.Applications.Include(x => x.Category).Where(x => x.Category.CategoryId == 5 && x.UserId == userId).ToListAsync();
            userDetails.OtherAppNumber = othApp.Count();
            var votes = await _dbContext.userVotes.Where(x => x.UserId == userId).ToListAsync();
            userDetails.VoteNumber = votes.Count();
            var comments = await _dbContext.Comments.Where(x => x.UserId == userId).ToListAsync();
            var commentResponses = await _dbContext.CommentResponses.Where(x => x.UserId == userId).ToListAsync();
            userDetails.CommentNumber = commentResponses.Count() + comments.Count();

            return userDetails;
        }
    }


}
