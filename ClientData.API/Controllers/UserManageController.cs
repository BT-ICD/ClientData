using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientData.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ClientData.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManageController : ControllerBase
    {
        private UserManager<ApplicationUser> userManager;
        //To implement custom password hasher - to store password without encryption
        private CustomPasswordHasher customPasswordHasher;
        public UserManageController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
            this.customPasswordHasher = new CustomPasswordHasher();
            userManager.PasswordHasher = customPasswordHasher;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUserAsync(LoginModel model)
        {
            ApplicationUser user = new ApplicationUser()
            {
                UserName = model.Username
            };
            var result = await userManager.CreateAsync(user, model.Password);
            //Currently added user as Admin - Need to enhance this functionality
            await userManager.AddToRoleAsync(user, "Admin");

            return Ok(result);
        }
    }
}