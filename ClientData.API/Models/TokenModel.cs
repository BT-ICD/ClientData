using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientData.API.Models
{
    /// <summary>
    /// Model to store token detail 
    /// </summary>
    public class TokenModel
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public string  Role { get; set; }

    }
}
