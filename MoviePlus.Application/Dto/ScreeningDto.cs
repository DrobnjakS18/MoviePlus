using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Dto
{
    public class ScreeningDto
    {

        public int Id { get; set; }

        public int MovieId { get; set; }

        public string Auditorium { get; set; }

        public int Seats { get; set; }

        public DateTime ScreeningTime { get; set; }
    }
}
