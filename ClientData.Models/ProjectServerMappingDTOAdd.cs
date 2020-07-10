using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.Models
{
    public class ProjectServerMappingDTOAdd
    {
        public int ProjectId { get; set; }
        public int ServerId { get; set; }
        public int DeployedServerTypeId { get; set; }
        public string UrlToAccess { get; set; }
        public string DeployedLocation { get; set; }
        public string AppLogLocation { get; set; }
        public int DbServerID { get; set; }
        public string DbName { get; set; }
        public string Notes { get; set; }
    }
}
