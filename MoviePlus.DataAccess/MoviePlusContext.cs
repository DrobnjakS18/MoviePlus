using Microsoft.EntityFrameworkCore;
using MoviePlus.DataAccess.Configurations;
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
                   Password = "pass123",
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

            //Proveriti kasnije UseCaseId
            var userUseCases = new List<UserUseCases>
            {
                new UserUseCases {
                    Id = 1,
                    UserId = 2,
                    UseCaseId = 1,
                },
                new UserUseCases {
                    Id = 2,
                    UserId = 2,
                    UseCaseId = 2,
                },
                new UserUseCases {
                    Id = 3,
                    UserId = 2,
                    UseCaseId = 3,
                },
                new UserUseCases {
                    Id = 4,
                    UserId = 2,
                    UseCaseId = 4,
                },
            };

            var movies = new List<Movie>
            {
                new Movie {
                    Id = 1,
                    Title = "The Shawshank Redemption ",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Duration = 142,
                },
                new Movie {
                    Id = 2,
                    Title = "The Godfather",
                    Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                    Duration = 175,
                },
                new Movie {
                    Id = 3,
                    Title = "The Dark Knight",
                    Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Duration = 152,
                },
                new Movie {
                    Id = 4,
                    Title = "12 Angry Men",
                    Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                    Duration = 96,
                },
                new Movie {
                    Id = 5,
                    Title = "Schindler's List",
                    Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                    Duration = 195,
                },
                new Movie {
                    Id = 6,
                    Title = "The Lord of the Rings: The Return of the King",
                    Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                    Duration = 201,
                },
                new Movie {
                    Id = 7,
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    Duration = 154,
                }
            };

            var dateTime = DateTime.Now;
            //dateTime.Hour

            var screening = new List<Screening>
            {
                new Screening {
                    Id = 1,
                    MovieId = 1,
                    AuditoriumId = 1,
                    ScreeningTime = new DateTime (2020, 7, 1, 15, 0, 0)
                },
                new Screening {
                    Id = 2,
                    MovieId = 3,
                    AuditoriumId = 2,
                    ScreeningTime = new DateTime (2020, 7, 2, 17, 0, 0)
                },
                new Screening {
                    Id = 3,
                    MovieId = 5,
                    AuditoriumId = 2,
                    ScreeningTime = new DateTime (2020, 7, 3, 20, 0, 0)
                },
            };


            var auditoriums = new List<Auditorium>
            {
                new Auditorium {
                    Id = 1,
                    Name = "Auditorium 1",
                    SeatNumbers = 20
                },
                new Auditorium {
                    Id = 2,
                    Name = "Auditorium 2",
                    SeatNumbers = 30
                },
            };

            var seats = new List<Seat>
            {
                new Seat
                {
                    Id = 1,
                    Row = 1,
                    Number = 1,
                    AuditoriumId = 1
                },
                new Seat
                {
                    Id = 2,
                    Row = 1,
                    Number = 2,
                    AuditoriumId = 1
                },
                new Seat
                {
                    Id = 3,
                    Row = 2,
                    Number = 1,
                    AuditoriumId = 2
                },
            };

            var seatsReserved = new List<SeatReserved>
            {
                new SeatReserved {
                    Id = 1,
                    SeatId = 1,
                    ReservationId = 1,
                    ScreeningId = 1
                },
                 new SeatReserved {
                    Id = 2,
                    SeatId = 2,
                    ReservationId = 2,
                    ScreeningId = 1
                },
                  new SeatReserved {
                    Id = 3,
                    SeatId = 3,
                    ReservationId = 2,
                    ScreeningId = 1
                },
            };

            var reservations = new List<Reservation>
            {
                new Reservation {
                   Id = 1,
                   UserId = 1,
                   ScreeningId = 1
                },
                new Reservation {
                   Id = 2,
                   UserId = 2,
                   ScreeningId = 1
                },
                new Reservation {
                   Id = 3,
                   UserId = 2,
                   ScreeningId = 2
                }
            };


            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<UserUseCases>().HasData(userUseCases);
            modelBuilder.Entity<Movie>().HasData(movies);
            modelBuilder.Entity<Screening>().HasData(screening);
            modelBuilder.Entity<Auditorium>().HasData(auditoriums);
            modelBuilder.Entity<Seat>().HasData(seats);
            modelBuilder.Entity<SeatReserved>().HasData(seatsReserved);
            modelBuilder.Entity<Reservation>().HasData(reservations);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new ScreeningConfiguration());
            modelBuilder.ApplyConfiguration(new SeatConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
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
