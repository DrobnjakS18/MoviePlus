using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePlus.API.Core
{
    public class ApiSettings
    {
        public string DbConnectionString { get; set; }

        public string JwtIssuer { get; set; }
        public string JwtSecretKey { get; set; }
        public string SenderEmail { get; set; }
        public string SenderEmailPassword { get; set; }
        public string ApplicationInstance { get; set; }
    }
}
