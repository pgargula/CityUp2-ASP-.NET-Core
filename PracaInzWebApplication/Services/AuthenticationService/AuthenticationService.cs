using Microsoft.IdentityModel.Tokens;
using PracaInzWebApplication.Helpers;
using PracaInzWebApplication.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Services.AuthenticationService
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HashAlgorithmName HashAlgorithmName = HashAlgorithmName.SHA256;
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
                new Claim("Role",user.Role),
                new Claim("CityId",user.CityId.ToString()),
                new Claim("City",user.City.Name)
            };
            return claims;
        }

        public string HashPassword(string password, out string salt)
        {
            if (password == null)
                throw new ArgumentNullException(nameof(password));

            salt = GenerateSalt(128);
            byte[] hashPasswdSalt = HashPasswordWithSalt(password, salt);

            return Convert.ToBase64String(hashPasswdSalt);
        }

        public bool VerifyPassword(string password, string hashPassword, string salt)
        {
            if (password == null || salt == null)
                return false;
            byte[] hashPasswordToVerify = HashPasswordWithSalt(password, salt);
            if (hashPassword == Convert.ToBase64String(hashPasswordToVerify))
                return true;
            else
                return false;
        }


        private string GenerateSalt(int byteLength)
        {
            using (var cryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                var salt = new byte[byteLength];
                cryptoServiceProvider.GetBytes(salt);
                return Convert.ToBase64String(salt);
            }
        }
        private byte[] HashPasswordWithSalt(string password, string salt)
        {
            byte[] hash;
            using (var hashAlgorithm = HashAlgorithm.Create(HashAlgorithmName.Name))
            {
                var passwdSalt = password + salt;
                byte[] input = Encoding.UTF8.GetBytes(passwdSalt);

                hash = hashAlgorithm.ComputeHash(input);
            }

            return hash;
        }

    }
}
