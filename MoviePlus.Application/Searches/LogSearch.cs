using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Searches
{
    public class LogSearch : PerPage
    {
        public string UseCase { get; set; }

        public string Data { get; set; }

        public string Actor { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }
    }
}
