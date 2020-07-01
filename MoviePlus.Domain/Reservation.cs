using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    public class Reservation : Entity
    {
        public int UserId { get; set; }

        public int ScreeningId { get; set; }

        public virtual User User { get; set; }

        public virtual Screening Screening { get; set; }

        public virtual ICollection<SeatReserved> SeatReserveds { get; set; }
    }
}
