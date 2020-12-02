using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientData.API.Data
{
    public class TokenSettingsOptions
    {
        public const string TokenSettings = "TokenSettings";
        public string Key { get;  set; }
        public int DurationMinutes { get;  set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
    }
}
