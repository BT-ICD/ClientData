using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientData.DAL;
using ClientData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientData.API.Controllers
{
    
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class ServerTypeController : ControllerBase
    {
        private readonly IServerTypeRepository _IServerTypeRepository;
        public ServerTypeController(IServerTypeRepository iServerTypeRepository)
        {
            this._IServerTypeRepository = iServerTypeRepository;
        }
        [HttpGet]
        public IActionResult List()
        {
            var result = _IServerTypeRepository.List();
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var result = _IServerTypeRepository.GetById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add(ServerTypeDTODetail serverTypeDTOAdd)
        {
            var result = _IServerTypeRepository.Add(serverTypeDTOAdd);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Edit(ServerTypeDTODetail serverTypeDTOEdit)
        {
            var result = _IServerTypeRepository.Edit(serverTypeDTOEdit);
            return Ok(result);
        }
        [HttpPost]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = _IServerTypeRepository.Delete(id);
            return Ok(result);
        }
    }
}