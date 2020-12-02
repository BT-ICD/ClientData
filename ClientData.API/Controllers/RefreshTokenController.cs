using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ClientData.API.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ClientData.API.Controllers
{
    /// <summary>
    /// Controller to get new token from existing token. Provides refresh token 
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]

    
    public class RefreshTokenController : ControllerBase
    {
        private readonly ILogger<RefreshTokenController> logger;
        private readonly TokenGenerator tokenGenerator;
        public RefreshTokenController(ILogger<RefreshTokenController> logger, TokenGenerator  tokenGenerator)
        {
            this.logger = logger;
            this.tokenGenerator = tokenGenerator;
        }
        /// <summary>
        /// Method to generate refresh token
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Refresh()
        {
            //Learning Reference - https://stackoverflow.com/questions/58887151/how-to-access-token-data-from-controller-method
           //Alternate way to access user name and role
            /*
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                if (identity != null)
                {
                    var uname = identity.Name;
                    var rolename = identity.Claims.Where(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role").FirstOrDefault().Value;
                }
            */
            var token =   HttpContext.GetTokenAsync("access_token");
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var jwtSecurityToken =  jwtSecurityTokenHandler.ReadJwtToken(token.Result);
            var claims = jwtSecurityToken.Claims;
            var userName = claims.Where(c => c.Type == "unique_name").FirstOrDefault().Value;
            var userRole = claims.Where(c => c.Type == "role").FirstOrDefault().Value;
            logger.LogInformation("For Refresh Token - User Name: " + userName + " Role: " + userRole);
            var newTokenString = tokenGenerator.GenerateToken(userName, userRole);
            return Ok(newTokenString);

        }
    }
}