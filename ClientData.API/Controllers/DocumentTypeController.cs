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
    //[Authorize]
    public class DocumentTypeController : ControllerBase
    {
        private readonly IDocumentTypeRepository _iDocumentTypeRepository;
        public DocumentTypeController(IDocumentTypeRepository _iDocumentTypeRepository)
        {
            this._iDocumentTypeRepository = _iDocumentTypeRepository;
        }
        [HttpGet]
        public IActionResult List()
        {
            var result = _iDocumentTypeRepository.List();
            return Ok(result);
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            var result = _iDocumentTypeRepository.GetById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add(DocumentTypeDTOAdd documentTypeDTOAdd)
        {
            var result = _iDocumentTypeRepository.Add(documentTypeDTOAdd);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Edit(DocumentTypeDTODetail documentTypeDTODetail)
        {
            var result = _iDocumentTypeRepository.Edit(documentTypeDTODetail);
            return Ok(result);
        }
        [HttpPost]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            var result = _iDocumentTypeRepository.Delete(id);
            return Ok(result);
        }
    }
}