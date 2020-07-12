using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Dto
{
    public class SeatReservedDto
    {
        public int SeatId { get; set; }

        public int ReservationId { get; set; }

        public int ScreeningId { get; set; }
    }
}
