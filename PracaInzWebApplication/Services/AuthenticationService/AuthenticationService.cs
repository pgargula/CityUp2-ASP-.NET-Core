using Microsoft.IdentityModel.Tokens;
using PracaInzWebApplication.Helpers;
using PracaInzWebApplication.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.AuthenticationService
{
    public class AuthenticationService : IAuthenticationService
    {
        public async Task<string> GetToken(User user)
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
            var token = new JwtSecurityTokenHandler().WriteToken(JWToken);
            return token;
        }

        private IEnumerable<Claim> _getUserClaims(User user)
        {
            IEnumerable<Claim> claims = new Claim[]
            {
                new Claim(ClaimTypes.Name, user.UserId+user.Login),
                new Claim("Id",user.UserId.ToString()),
                new Claim("Login", user.Login),
                new Claim("Role",user.Role)
            };
            return claims;
        }

    }
}
