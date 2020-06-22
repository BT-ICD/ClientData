using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientData.API.Data
{
    public class SampleModelWithFile
    {
        public int projectId { get; set; }
        public string projectName { get; set; }
        public IFormFile file { get; set; }
    }
}
