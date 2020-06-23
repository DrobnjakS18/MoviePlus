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


        public ICollection<Seat> Seats { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Screening> Screenings { get; set; }
    }
}
