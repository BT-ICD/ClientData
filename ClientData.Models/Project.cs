using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Notes { get; set; }
        public string SourceCodeLocation { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdatedBy { get; set; }
    }
}
