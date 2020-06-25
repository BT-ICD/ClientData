using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientData.API.Data
{
    public class ProjectDocumentMappingDTOUpload
    {
        public int ProjectId { get; set; }
        public int DocumentTypeId { get; set; }
        public string Notes { get; set; }
        public IFormFile file { get; set; }
    }
}
