using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClientData.DAL;
using ClientData.Models;
using Microsoft.AspNetCore.Authorization;

namespace ClientData.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
   [Authorize]
    public class ServerController : ControllerBase
    {
        private readonly IServerRepository _IServerRepository;
        public ServerController(IServerRepository _IServerRepository)
        {
            this._IServerRepository = _IServerRepository;
        }
        [HttpGet]
        public IActionResult List()
        {
            var result = _IServerRepository.List();
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var result = _IServerRepository.GetById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add(ServerDTODetail serverDTODetail)
        {
            var result = _IServerRepository.Add(serverDTODetail);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Edit(ServerDTODetail serverDTODetail)
        {
            var result = _IServerRepository.Edit(serverDTODetail);
            return Ok(result);
        }
        [HttpPost]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = _IServerRepository.Delete(id);
            return Ok(result);
        }
        /// <summary>
        /// Method to get list of server Id and Server Name. Optionally filter by Server Type ID
        /// Specially to fill server dropdown
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id:int?}")]
        public IActionResult ListForLOV(int? id)
        {
            var result = _IServerRepository.ListForLOV(id);
            return Ok(result);
        }

    }
}