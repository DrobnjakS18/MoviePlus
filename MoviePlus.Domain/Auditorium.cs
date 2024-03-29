﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    //Sale 
    public class Auditorium : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<Screening> Screenings { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }

        //public ICollection<Movie> Movies { get; set; }
    }
}
