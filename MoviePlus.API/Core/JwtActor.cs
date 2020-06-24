using MoviePlus.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePlus.API.Core
{
    public class JwtActor : IApplicationUser
    {
        public int id { get; set; }

        public string Identity { get; set; }

        public IEnumerable<int> AllowedUseCases { get; set; } = new List<int> { 1, 2, 3, 4, 5 };//UseCase komande koje su dozvoljenje za ulogovanog korisnika
    }
}
