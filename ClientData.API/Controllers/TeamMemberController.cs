using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClientData.Models;
using ClientData.DAL;
using Microsoft.Extensions.Logging;

namespace ClientData.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeamMemberController : ControllerBase
    {
        private readonly ITeamMemberRepository _IteamMemberRepository;
        private readonly ILogger<TeamMemberController> _logger;
        public TeamMemberController(ITeamMemberRepository teamMemberRepository, ILogger<TeamMemberController> logger)
        {
            _IteamMemberRepository = teamMemberRepository;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult List()
        {
            var result = _IteamMemberRepository.List();
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var result = _IteamMemberRepository.GetById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add(TeamMemberDTODetail teamMemberDTODetail)
        {
            var result = _IteamMemberRepository.Add(teamMemberDTODetail);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Edit(TeamMemberDTODetail teamMemberDTODetail)
        {
            var result = _IteamMemberRepository.Edit(teamMemberDTODetail);
            return Ok(result);
        }
        [HttpPost]
        [Route("{id:int}")]
        public IActionResult Delete (int id)
        {
            var result = _IteamMemberRepository.Delete(id);
            return Ok(result);
        }

    }
}