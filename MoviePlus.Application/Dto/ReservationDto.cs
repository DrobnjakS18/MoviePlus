using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Dto
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public int ScreeningId { get; set; }

        public int AuditoriumId { get; set; }
    }
}
