using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Searches
{
    public class UsersSearch : PerPage
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Usernam { get; set; }
    }
}
