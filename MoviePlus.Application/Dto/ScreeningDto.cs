using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Dto
{
    public class ScreeningDto
    {

        public int Id { get; set; }

        public int MovieId { get; set; }

        public string MovieName { get; set; }

        public string AuditoriumName { get; set; }

        public int AuditoriumId { get; set; }

        public int Seats { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public DateTime ScreeningTime { get; set; }

    }
}
