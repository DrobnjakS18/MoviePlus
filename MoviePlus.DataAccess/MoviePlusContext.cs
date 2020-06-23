using Microsoft.EntityFrameworkCore;
using MoviePlus.DataAccess.Seeders;
using MoviePlus.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.DataAccess
{
    public class MoviePlusContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var users = new List<User>
            {
                new User {
                   Id = 1,
                   FirstName = "Admin",
                   LastName = "Admin",
                   Email = "admin@gmail.com",
                   Username = "adminAdmin",
                   Password = "pass123"
                },
                new User {
                   Id =2,
                   FirstName = "User",
                   LastName = "user",
                   Email = "user@gmail.com",
                   Username = "userUser",
                   Password = "pass123"
                },
            };


            modelBuilder.Entity<User>().HasData(users);



        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=movie_plus;Integrated Security=True");
        }

        public DbSet<AuditLogger> AuditLogger { get; set; }
        public DbSet<UserUseCases> UserUseCases { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Auditorium> Auditoriums { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatReserved> SeatsReserved { get; set; }
    }
}
