using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.Models
{
    public class ProjectDeploymentDTOAdd
    {
        public int ProjectId { get; set; }
        public DateTime DeploymentDate { get; set; }
        public int ServerId { get; set; }
        public string Features { get; set; }
        public string Version { get; set; }
        public string ActualFileName { get; set; }
        public string Notes { get; set; }

    }
}
