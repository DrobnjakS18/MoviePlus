using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Searches
{
    public abstract class PerPage
    {
        public int ItemsPerPage { get; set; } = 10;

        public int CurrentPage { get; set; } = 1;
    }
}
