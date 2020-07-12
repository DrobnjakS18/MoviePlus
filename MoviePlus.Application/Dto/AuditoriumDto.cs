using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Application.Dto
{
    public class AuditoriumDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public int SeatsSum => AuditoirumSeats.Count();

        public IEnumerable<AuditoirumSeats> AuditoirumSeats { get; set; } = new List<AuditoirumSeats>();

    }

    public class AuditoirumSeats
    {
        public int Id { get; set; }

        public int Number { get; set; }
    }
}
