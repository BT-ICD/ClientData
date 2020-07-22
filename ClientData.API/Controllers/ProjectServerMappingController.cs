using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClientData.Models;
using ClientData.DAL;
using Microsoft.AspNetCore.Authorization;

namespace ClientData.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
  //  [Authorize]
    public class ProjectServerMappingController : ControllerBase
    {
        private readonly IProjectServerMappingRepository _IProjectServerMappingRepository;
        public ProjectServerMappingController(IProjectServerMappingRepository _IProjectServerMappingRepository)
        {
            this._IProjectServerMappingRepository = _IProjectServerMappingRepository;
        }
        [HttpGet]
        [Route("{projectId:int}")]
        public IActionResult List(int projectId)
        {
            var result = _IProjectServerMappingRepository.List(projectId);
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var result = _IProjectServerMappingRepository.GetById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add(ProjectServerMappingDTOAdd projectServerMappingDTODetail)
        {
            var resutlt = _IProjectServerMappingRepository.Add(projectServerMappingDTODetail);
            return Ok(resutlt);
        }
        [HttpPost]
        public IActionResult Edit(ProjectServerMappingDTOEdit projectServerMappingDTODetail)
        {
            var resutlt = _IProjectServerMappingRepository.Edit(projectServerMappingDTODetail);
            return Ok(resutlt);
        }
        [HttpPost]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = _IProjectServerMappingRepository.Delete(id);
            return Ok(result);
        }
    }
}