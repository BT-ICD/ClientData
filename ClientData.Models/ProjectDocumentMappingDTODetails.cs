using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.Models
{
    public class ProjectDocumentMappingDTODetails
    {
        public int ProjectDocumentMappingId { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentType { get; set; }
        public string ActualFileName { get; set; }
        public string StoreAsFileName { get; set; }
        public string Notes { get; set; }
    }
}
