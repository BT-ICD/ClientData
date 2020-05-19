using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.Models
{
    public class ProjectDTODetail
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Notes { get; set; }
        public string SourceCodeLocation { get; set; }
    }
}
