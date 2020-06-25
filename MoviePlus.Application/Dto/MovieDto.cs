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

        public int Auditorium { get; set; }

        public int Time { get; set; }

        public int Tickets { get; set; }
    }
}
