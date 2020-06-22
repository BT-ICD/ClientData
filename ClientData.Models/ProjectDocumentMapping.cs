using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.Models
{
    public class ProjectDocumentMapping
    {
        public int ProjectDocumentMappingId { get; set; }
        public int ProjectId { get; set; }
        public int DocumentTypeId { get; set; }
        public string ActualFileName { get; set; }
        public string StoreAsFileName { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdatedBy { get; set; }
    }
}
