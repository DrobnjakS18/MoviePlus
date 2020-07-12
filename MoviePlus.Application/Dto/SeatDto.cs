using MoviePlus.Application.Searches;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Dto
{
    public class SeatDto
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string AuditoriumName { get; set; }

        public IEnumerable<SeatReservations> SeatReserved { get; set; } = new List<SeatReservations>();
    }

    public class SeatReservations
    {
        public int RezervationId { get; set; }

        public DateTime ScreeningTime { get; set; }
    }

}
