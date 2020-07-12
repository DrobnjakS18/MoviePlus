using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    public class SeatReserved
    {
        //Ne nasledjuju Entity klasu zato sto imaju kompozitni kljuc( kombinacija stranih kljuceva koji predstavljaju primarni kljuc za ovu tabelu) 
        public int SeatId { get; set; }

        public int ReservationId { get; set; }

        public int ScreeningId { get; set; }

        public virtual Seat Seat { get; set; }

        public virtual Reservation Reservation { get; set; }

        public virtual Screening Screening { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedAt { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
