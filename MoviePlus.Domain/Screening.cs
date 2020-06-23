﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    public class Screening : Entity
    {
        public int MovieId { get; set; }

        public int AuditoriumId { get; set; }

        public DateTime ScreeningTime { get; set; }

        public ICollection<Movie> Movies { get; set; }
        public ICollection<Auditorium> Auditoriums { get; set; }
    }
}
