using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Searches
{
    public class SeatSearch : PerPage
    {
        public int MinSeatNumber { get; set; }

        public int MaxSeatNumber { get; set; }

        public string Auditorium { get; set; }
    }

}
