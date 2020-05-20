using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.Models
{
   public class ProjectServerMapping
    {
        public int ProjectServerMappingId { get; set; }
        public int ProjectId { get; set; }
        public int ServerId { get; set; }
        public int DeployedServerTypeId { get; set; }
        public string UrlToAccess { get; set; }
        public string DeployedLocation { get; set; }
        public string AppLogLocation { get; set; }
        public int DbServerID { get; set; }
        public string DbName { get; set; }
        public string Notes { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdatedBy { get; set; }
    }
}
