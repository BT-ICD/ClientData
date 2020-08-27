using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClientData.DAL;
using ClientData.Models;
using ClientData.API.Data;
using Microsoft.Extensions.Options;

namespace ClientData.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize]
    public class ProjectDeploymentController : ControllerBase
    {
        private readonly IProjectDeploymentRepository _IProjectDeploymentRepository;
        private readonly MyAppSettingsOptions myAppSettingsOptions;
        public ProjectDeploymentController(IProjectDeploymentRepository _IProjectDeploymentRepository, IOptions<MyAppSettingsOptions> myAppSettingsOptions)
        {
            this._IProjectDeploymentRepository = _IProjectDeploymentRepository;
            this.myAppSettingsOptions = myAppSettingsOptions.Value;
        }
        [HttpGet]
        [Route("{projectId:int}")]
        public IActionResult List(int projectId)
        {
            var result = _IProjectDeploymentRepository.List(projectId);
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var result = _IProjectDeploymentRepository.GetById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromForm] ProjectDeploymentDTOAddWithFile projectDeploymentDTOAddWithFile)
        {
            if (projectDeploymentDTOAddWithFile.file == null)
                return BadRequest("Invalid file, it must not null");
            long size = projectDeploymentDTOAddWithFile.file.Length;
            if (size == 0)
                return BadRequest("Invalid file");
            var documentFolderName = myAppSettingsOptions.DeploymentDocuments;
            var fileName = projectDeploymentDTOAddWithFile.file.FileName;

            ProjectDeploymentDTOAdd projectDeploymentDTOAdd = new ProjectDeploymentDTOAdd();
            projectDeploymentDTOAdd.ProjectId = projectDeploymentDTOAddWithFile.ProjectId;
            projectDeploymentDTOAdd.DeploymentDate = projectDeploymentDTOAddWithFile.DeploymentDate;
            projectDeploymentDTOAdd.ServerId = projectDeploymentDTOAddWithFile.ServerId;
            projectDeploymentDTOAdd.Features = projectDeploymentDTOAddWithFile.Features;
            projectDeploymentDTOAdd.Version = projectDeploymentDTOAddWithFile.Version;
            projectDeploymentDTOAdd.ActualFileName= fileName;
            projectDeploymentDTOAdd.Notes= projectDeploymentDTOAddWithFile.Notes;

            var result = _IProjectDeploymentRepository.Add(projectDeploymentDTOAdd);

            var filePathDocument = AppContext.BaseDirectory  + documentFolderName + "\\"+  result.StoreAsFileName;
            using (var stream = System.IO.File.Create(filePathDocument))
            {
                await projectDeploymentDTOAddWithFile.file.CopyToAsync(stream);
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit([FromForm] ProjectDeploymentDTOEditWithFile projectDeploymentDTOEditWithFile)
        {
            if (projectDeploymentDTOEditWithFile.file != null)
            {
                long size = projectDeploymentDTOEditWithFile.file.Length;
                if (size == 0)
                    return BadRequest("Invalid file");
            }
            ProjectDeploymentDTOEdit projectDeploymentDTOEdit = new ProjectDeploymentDTOEdit();
            projectDeploymentDTOEdit.ProjectDeploymentId = projectDeploymentDTOEditWithFile.ProjectDeploymentId;
            projectDeploymentDTOEdit.ProjectId = projectDeploymentDTOEditWithFile.ProjectId;
            projectDeploymentDTOEdit.DeploymentDate = projectDeploymentDTOEditWithFile.DeploymentDate;
            projectDeploymentDTOEdit.ServerId = projectDeploymentDTOEditWithFile.ServerId;
            projectDeploymentDTOEdit.Features = projectDeploymentDTOEditWithFile.Features;
            projectDeploymentDTOEdit.Version = projectDeploymentDTOEditWithFile.Version;
            projectDeploymentDTOEdit.Notes = projectDeploymentDTOEditWithFile.Notes;
            if (projectDeploymentDTOEditWithFile.file != null)
            {
                projectDeploymentDTOEdit.ActualFileName = projectDeploymentDTOEditWithFile.file.FileName;
            }
            var result = _IProjectDeploymentRepository.Edit(projectDeploymentDTOEdit);

            if(projectDeploymentDTOEditWithFile.file!=null)
            {
                var documentFolderName = myAppSettingsOptions.DeploymentDocuments;
                var fileName = projectDeploymentDTOEditWithFile.file.FileName;
                var filePathDocument = AppContext.BaseDirectory + documentFolderName + "\\" + result.StoreAsFileName;
                using (var stream = System.IO.File.Create(filePathDocument))
                {
                    await projectDeploymentDTOEditWithFile.file.CopyToAsync(stream);
                }
            }
            return Ok(result);
        }
        [HttpPost]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = _IProjectDeploymentRepository.Delete(id);
            return Ok(result);
        }
    }
}