using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientData.DAL;
using ClientData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ClientData.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientRepository _clientRepository;
        private readonly ILogger<ClientController> _logger;
        public ClientController(IClientRepository iClientRepository, ILogger<ClientController> logger)
        {
            _clientRepository = iClientRepository;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get()
        {
           // _logger.LogInformation("Get Method Begin");
            var result = _clientRepository.List();
            _logger.LogInformation("Records: " + result.Count);
            return Ok(result);
            
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            //To test exception log
           //if(id<0)
           // throw new ArgumentException("Invalid ID");
            var data = _clientRepository.GetById(id);
            if (data == null)
                return NotFound();
            return Ok(data);
                    
        }
    }
}