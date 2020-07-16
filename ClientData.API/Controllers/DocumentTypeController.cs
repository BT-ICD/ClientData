using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientData.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientData.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
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
    }
}