using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    public class Screening : Entity
    {
        public int MovieId { get; set; }

        public int AuditoriumId { get; set; }

        public DateTime ScreeningTime { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual  Auditorium Auditorium { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }

        public virtual ICollection<SeatReserved> SeatReserveds { get; set; }
    }
}
