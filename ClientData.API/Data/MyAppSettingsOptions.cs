using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientData.API.Data
{
    public class MyAppSettingsOptions
    {
        public const string MyAppSettings = "MyAppSettings";
        public string ProjectDocuments { get; set; }
        public string DeploymentDocuments { get; set; }
    }
}
