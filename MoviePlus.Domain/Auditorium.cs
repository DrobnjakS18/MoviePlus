using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    //Sale 
    public class Auditorium : Entity
    {
        public string Name { get; set; }

        public int SeatNumbers { get; set; }

        public ICollection<Screening> Screenings { get; set; }

        public ICollection<Seat> Seats { get; set; }
    }
}
