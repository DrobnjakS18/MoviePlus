using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Queries
{
    public class PageResponse<T> where T : class
    {
        public int TotalCount { get; set; }

        public int CurrentPage { get; set; }

        public int ItemsPerPage { get; set; }

        public IEnumerable<T> Items { get; set; }

        //Koliko ima ukupno stranica
        public int PageCount => (int)Math.Ceiling((float)TotalCount / ItemsPerPage);
    }
}
