using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.Models
{
    public class ProjectDeployment
    {
        public int ProjectDeploymentId { get; set; }
        public int ProjectId { get; set; }
        public DateTime DeploymentDate { get; set; }
        public int ServerId { get; set; }
        public string Features { get; set; }
        public string Version { get; set; }
        public string ActualFileName { get; set; }
        public string StoreAsFileName { get; set; }
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
