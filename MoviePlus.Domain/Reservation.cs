using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    public class Reservation : Entity
    {
        public int UserId { get; set; }

        public int ScreeningId { get; set; }

        public User User { get; set; }

        public Screening Screening { get; set; }

        public ICollection<SeatReserved> SeatReserved { get; set; }
    }
}
