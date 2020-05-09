using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ClientData.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;

        public ErrorController(ILogger<ClientController> logger)
        {
            _logger = logger;
        }
        //[Route("/error")]
        public IActionResult Error()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            _logger.LogError(context.Error.ToString());
            return Problem(
                detail: context.Error.StackTrace,
                title: context.Error.Message
                );

        }
    }
}