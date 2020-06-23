using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    //Sale 
    public class Auditorium : Entity
    {
        public string Name { get; set; }

        public int SeatNumbers { get; set; }
    }
}
