using MoviePlus.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Application.Dto
{
    public class LogDto
    {
        public int Id { get; set; }
        public string UseCase { get; set; }

        public string Data { get; set; }

        public string Actor { get; set; }

        public DateTime Date { get; set; }
    }
}
