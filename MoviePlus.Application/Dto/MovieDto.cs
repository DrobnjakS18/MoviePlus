using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Dto
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public string Auditorium { get; set; }

        public string Image { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public IEnumerable<ScreeningDto> ScreeningTime { get; set; }
    }
}
