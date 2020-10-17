using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientData.DAL;
using ClientData.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ClientData.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize]
    public class DocumentTypeController : ControllerBase
    {
        private readonly IDocumentTypeRepository _iDocumentTypeRepository;
        private readonly ILogger<DocumentTypeController> _logger;
        public DocumentTypeController(IDocumentTypeRepository _iDocumentTypeRepository, ILogger<DocumentTypeController> logger)
        {
            this._iDocumentTypeRepository = _iDocumentTypeRepository;
            this._logger = logger;
        }
        [HttpGet]
        public IActionResult List()
        {
            _logger.LogInformation("List method called");
            var result = _iDocumentTypeRepository.List();
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            _logger.LogInformation("Id: " + id);
            var result = _iDocumentTypeRepository.GetById(id);
            if (result == null)
                return NotFound();

            _logger.LogInformation(JsonConvert.SerializeObject(result));
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add(DocumentTypeDTOAdd documentTypeDTOAdd)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(documentTypeDTOAdd));
            var result = _iDocumentTypeRepository.Add(documentTypeDTOAdd);
            _logger.LogInformation(JsonConvert.SerializeObject(result));
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Edit(DocumentTypeDTODetail documentTypeDTODetail)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(documentTypeDTODetail));
            var result = _iDocumentTypeRepository.Edit(documentTypeDTODetail);

            _logger.LogInformation(result.ToString());
            return Ok(result);
        }
        [HttpPost]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation("Id: " + id);
            var result = _iDocumentTypeRepository.Delete(id);

            _logger.LogInformation(JsonConvert.SerializeObject(result));
            return Ok(result);
        }
    }
}