using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.Models
{
    public class TeamMember
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string AlternateContact { get; set; }
        public DateTime? DOJ { get; set; }
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
