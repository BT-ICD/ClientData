using ClientData.API.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClientData.API.Data
{
    /// <summary>
    /// Class to generate token
    /// </summary>
    public class TokenGenerator
    {
        private readonly TokenSettingsOptions _options;
        public TokenGenerator(IOptions<TokenSettingsOptions> options)
        {
            _options = options.Value;
        }
        public TokenModel GenerateToken(string userName, string userRole)
        {
            var tokenString = "";
            var tokenHandler = new JwtSecurityTokenHandler();
            var authSigninKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.Key));
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(
                    new Claim[] {
                        new Claim(ClaimTypes.Name, userName),
                        new Claim(ClaimTypes.Role, userRole)
                    }),
                Audience = _options.Audience,
                Issuer = _options.Issuer,
                Expires = DateTime.Now.AddMinutes(_options.DurationMinutes),
                SigningCredentials = new SigningCredentials(authSigninKey,SecurityAlgorithms.HmacSha256)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            tokenString = tokenHandler.WriteToken(token);
            return new TokenModel() { 
                Token = tokenString,
                Expiration= token.ValidTo,
                Role = userRole
            };
        }
    }
}
