using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Searches
{
    public class MovieSearch : PerPage
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Date { get; set; }
        public int Duration { get; set; }
    }
}
