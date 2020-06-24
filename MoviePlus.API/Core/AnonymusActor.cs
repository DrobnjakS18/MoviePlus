using MoviePlus.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePlus.API.Core
{
    public class AnonymusActor : IApplicationUser
    {
        public int id => 3;

        public string Identity => "Anonymus user";

        public IEnumerable<int> AllowedUseCases => new List<int> { 1 };
    }
}

