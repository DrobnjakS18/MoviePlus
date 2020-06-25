using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    public class Seat : Entity
    {

        public int Number { get; set; }

        public int AuditoriumId { get; set; }

        public Auditorium Auditorium { get; set; }

        public ICollection<SeatReserved> SeatReserved { get; set; }
    }
}
