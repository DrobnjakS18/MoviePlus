using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Searches
{
    public abstract class PerPage
    {
        //Defaultna vrednost u slucaju da se ne prosledi je 10
        public int ItemsPerPage { get; set; } = 10;

        public int CurrentPage { get; set; } = 1;
    }
}
