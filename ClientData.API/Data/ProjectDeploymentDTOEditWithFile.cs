using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientData.API.Data
{
    public class ProjectDeploymentDTOEditWithFile
    {
        public int ProjectDeploymentId { get; set; }
        public int ProjectId { get; set; }
        public DateTime DeploymentDate { get; set; }
        public int ServerId { get; set; }
        public string Features { get; set; }
        public string Version { get; set; }
        
        public string Notes { get; set; }

        public IFormFile? file { get; set; }
    }
}
