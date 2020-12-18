using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.Models
{
    /// <summary>
    /// To add new team member. Maintain details of team member to add into database
    /// </summary>
    public class TeamMemberDTODetailAdd
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string AlternateContact { get; set; }
        public DateTime? DOJ { get; set; }
        public string Notes { get; set; }
    }
}
