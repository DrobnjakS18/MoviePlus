using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Domain
{
    public class User : Entity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

        public ICollection<UserUseCases> UserUseCases { get; set; }
    }
}
