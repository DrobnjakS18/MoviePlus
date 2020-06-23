using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    public class AuditLogger 
    {
        public int Id { get; set; }
        public string UseCaseName { get; set; }
        public string Data { get; set; }

        public string Actor { get; set; }

        public DateTime Time { get; set; }
    }
}
