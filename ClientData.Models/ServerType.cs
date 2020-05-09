using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClientData.Models
{
    public class ServerType
    {
        [Required]
        public int ServerTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public string? DeletedBy { get; set; }
    }
}
