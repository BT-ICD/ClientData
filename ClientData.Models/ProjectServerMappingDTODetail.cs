using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.Models
{
    public class ProjectServerMappingDTODetail
    {
        public int ProjectServerMappingId { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ServerId { get; set; }
        public string ServerName { get; set; }
        public string ActualServerType { get; set; }
        public int DeployedServerTypeId { get; set; }
        public string DeployedAsServerType { get; set; }
        public string UrlToAccess { get; set; }
        public string DeployedLocation { get; set; }
        public string AppLogLocation { get; set; }
        public string DatabaseServerName { get; set; }
        public int DbServerID { get; set; }
        public string DbName { get; set; }
        public string Notes { get; set; }
    }
}
