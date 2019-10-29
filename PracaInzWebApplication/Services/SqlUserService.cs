using Microsoft.IdentityModel.Tokens;
using PracaInzWebApplication.Helpers;
using PracaInzWebApplication.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services
{
    public class SqlUserService : IUserService
    {
        private List<User> _userList = new List<User>
        {
            new User(){Id=1, Login="test", Password="test", Email="test@test.pl",City = 1}
        };

        private IEnumerable<Claim> _getUserClaims(User user)
        {
            IEnumerable<Claim> claims = new Claim[]
            {
                new Claim(ClaimTypes.Name, user.Id+user.Login),
                new Claim("Id",user.Id.ToString()),
                new Claim("Login", user.Login)    
            };
            return claims;
        }


        public JwtSecurityToken LoginUser(string login, string password)
        {
            User user = _userList.Single(x => x.Login == login);

            if (user == null)
                return null;
            if (user.Password == password)
            {
                var secretKey = System.Text.Encoding.ASCII.GetBytes("70ZaBE-5LxoAjV4ibfCdS8afpizTY60GjY7tebchbTHTiayOQa1Eaetxy5T4nS7DVf");
                //Generate Token for user 
                var JWToken = new JwtSecurityToken(
                    issuer: Consts.appAdress,
                    audience: Consts.appAdress,
                    claims: _getUserClaims(user),
                    notBefore: new DateTimeOffset(DateTime.Now).DateTime,
                    expires: new DateTimeOffset(DateTime.Now.AddDays(1)).DateTime,
                    //Using HS256 Algorithm to encrypt Token
                    signingCredentials: new SigningCredentials(new SymmetricSecurityKey(secretKey),
                                        SecurityAlgorithms.HmacSha256Signature)
                );
                return JWToken;
            }
            else
                return null;
           
        }

    }
}
