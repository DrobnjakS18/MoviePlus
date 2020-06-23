using MoviePlus.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.DataAccess.Seeders
{
    public class UserSeeder
    {
        //Ne radi
        public List<User> users => new List<User>
        {
            new User {
               FirstName = "Admin",
               LastName = "Admin",
               Email = "admin@gmail.com",
               Username = "adminAdmin",
               Password = "pass123"
            },
            new User {
               FirstName = "User",
               LastName = "user",
               Email = "user@gmail.com",
               Username = "userUser",
               Password = "pass123"
            },
        };
    }
}
