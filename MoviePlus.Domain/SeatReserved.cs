using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    public class SeatReserved : Entity
    {
        public int SeatId { get; set; }

        public int ReservationId { get; set; }

        public int ScreeningId { get; set; }

        public Seat Seat { get; set; }
        public Reservation Reservation { get; set; }
        public Screening Screening { get; set; }
    }
}
