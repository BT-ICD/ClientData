using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientData.API.Data;
using ClientData.DAL;
using ClientData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

using System.IO;
namespace ClientData.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectDocumentMappingController : ControllerBase
    {
        private readonly IProjectDocumentMappingRepository _IProjectDocumentMappingRepository;
        private readonly MyAppSettingsOptions myAppSettingsOptions; 
        public ProjectDocumentMappingController(IProjectDocumentMappingRepository _IProjectDocumentMappingRepository, IOptions<MyAppSettingsOptions> myAppSettingsOptions)
        {
            this._IProjectDocumentMappingRepository = _IProjectDocumentMappingRepository;
            this.myAppSettingsOptions = myAppSettingsOptions.Value;
        }
        [HttpGet]
        [Route("{projectId:int}")]
        public IActionResult List(int projectId)
        {
            var result = _IProjectDocumentMappingRepository.List(projectId);
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var result = _IProjectDocumentMappingRepository.GetById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync(ProjectDocumentMappingDTODetails projectDocumentMappingDTODetails, IFormFile file)
        {
            long size = file.Length;
            var documentFolderName = myAppSettingsOptions.ProjectDocuments;
            var fileName = file.FileName;
            var filePathDocument = AppContext.BaseDirectory + documentFolderName + "\\" + fileName;
            using (var stream = System.IO.File.Create(filePathDocument))
            {
                await file.CopyToAsync(stream);
            }
            var result = _IProjectDocumentMappingRepository.Add(projectDocumentMappingDTODetails);
            //Upload Document
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Edit(ProjectDocumentMappingDTODetails projectDocumentMappingDTODetails)
        {
            var result = _IProjectDocumentMappingRepository.Edit(projectDocumentMappingDTODetails);
            return Ok(result);
        }
        [HttpPost]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = _IProjectDocumentMappingRepository.Delete(id);
            return Ok(result);
        }



        /// <summary>
        /// Learning Resources - 
        /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http.httprequest?view=aspnetcore-3.1
        /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http.iformcollection?view=aspnetcore-3.1
        /// https://stackoverflow.com/questions/51892706/asp-net-core-web-api-file-upload-and-form-data-multiple-parameter-passing-to-m
        /// Reading Multipart - Form Data - https://docs.microsoft.com/en-us/aspnet/web-api/overview/advanced/sending-html-form-data-part-2
        /// </summary>

        [HttpPost]
        public async Task<IActionResult> Upload([FromForm] SampleModelWithFile obj)
        {

            long size = obj.file.Length;
            var documentFolderName = myAppSettingsOptions.ProjectDocuments;
            var fileName = obj.file.FileName;
            var uploadPathWithFileName = Path.Combine(AppContext.BaseDirectory, documentFolderName, fileName);
            using (var stream = System.IO.File.Create(uploadPathWithFileName))
            {
                await obj.file.CopyToAsync(stream);
            }
          
          
            /* To access details using HttpContext.Request.Form - this does not requir any argument in Upload Method - user can pass any number of field in Formdata
                int projectId1;
                string projectName1;
                var form = HttpContext.Request.Form; 
                var request = HttpContext.Request;
                var files = form.Files;
                foreach (var f in files)
                {
                    var filename = f.FileName;
                }
                if (form.ContainsKey("projectId"))
                {
                   projectId1= Convert.ToInt32( form["projectId"] );
                    projectName1 = form["projectName"];
                } 
            */
           // HttpContext.Request.Body
            return Ok();
        }
    }
}