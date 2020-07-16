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
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepository _IProjectRepository;
        public ProjectController(IProjectRepository _IProjectRepository)
        {
            this._IProjectRepository = _IProjectRepository;
        }
        [HttpGet]
        public IActionResult List()
        {
            var result = _IProjectRepository.List();
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var result = _IProjectRepository.GetById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add(ProjectDTODetail projectDTODetail)
        {
            var result = _IProjectRepository.Add(projectDTODetail);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Edit(ProjectDTODetail projectDTODetail)
        {
            var result = _IProjectRepository.Edit(projectDTODetail);
            return Ok(result);
        }
        [HttpPost]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = _IProjectRepository.Delete(id);
            return Ok(result);
        }
    }
}