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
        public async Task<IActionResult> Add([FromForm] ProjectDocumentMappingDTOUpload projectDocumentMappingDTOUpload)
        {

            if (projectDocumentMappingDTOUpload.file == null)
            {
                return BadRequest("Invalid File, it must not null.");
            }
            long size = projectDocumentMappingDTOUpload.file.Length;
            if (size ==0)
            {
                return BadRequest("Invalid File.");
            }
            var documentFolderName = myAppSettingsOptions.ProjectDocuments;
            var fileName = projectDocumentMappingDTOUpload.file.FileName;
            

            ProjectDocumentMappingDTODetails projectDocumentMappingDTODetails = new ProjectDocumentMappingDTODetails();
            projectDocumentMappingDTODetails.ProjectId = projectDocumentMappingDTOUpload.ProjectId;
            projectDocumentMappingDTODetails.DocumentTypeId = projectDocumentMappingDTOUpload.DocumentTypeId;
            projectDocumentMappingDTODetails.Notes = projectDocumentMappingDTOUpload.Notes;
            projectDocumentMappingDTODetails.ActualFileName = projectDocumentMappingDTOUpload.file.FileName;

            var result = _IProjectDocumentMappingRepository.Add(projectDocumentMappingDTODetails);

            var filePathDocument = AppContext.BaseDirectory + documentFolderName + "\\" + result.StoreAsFileName;
            using (var stream = System.IO.File.Create(filePathDocument))
            {
                await projectDocumentMappingDTOUpload.file.CopyToAsync(stream);
            }
           
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
        /// https://www.c-sharpcorner.com/article/upload-download-files-in-asp-net-core-2-0/
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
        /// <summary>
        /// Method which allows user to download file from ProdumentDocumentMappingID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       [HttpGet]
       [Route("{id:int}")]
       public async Task<IActionResult> Download(int id)
        {
            var result = _IProjectDocumentMappingRepository.GetById(id);
            if (result == null)
                return NotFound();
            string fileName = result.StoreAsFileName;
            var documentFolderName = myAppSettingsOptions.ProjectDocuments;
            var path = Path.Combine(AppContext.BaseDirectory, documentFolderName, fileName);
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "application/octet-stream", fileName);
            //var stream = System.IO.File.OpenRead(path);
            //return new FileStreamResult(stream, "application/octet-stream");
        }
    }
    
}