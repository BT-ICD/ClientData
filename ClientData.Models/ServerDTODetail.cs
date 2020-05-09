using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClientData.Models
{
    public class ServerDTODetail
    {
        public int ServerId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public int ServerTypeId { get; set; }
        public string ServerTypeName { get; set; }
        public string? InternalIP { get; set; }
        public string? ExternalIP { get; set; }
        public string? URLToAccess { get; set; }
        public string? Notes { get; set; }
        
    }
}
