using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    public class Movie : Entity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }
    }
}
