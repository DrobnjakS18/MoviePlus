using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    public class Seat : Entity
    {
        public int Row { get; set; }

        public int Number { get; set; }

        public int AuditoriumId { get; set; }

        public ICollection<Auditorium> Auditoriums { get; set; }
    }
}
