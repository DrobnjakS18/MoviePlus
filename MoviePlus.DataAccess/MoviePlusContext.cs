using Microsoft.EntityFrameworkCore;
using MoviePlus.DataAccess.Configurations;
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
                   Password = "A12450CFF6FB7A97C975BFB7FCBB8F7E",
                },
                new User {
                   Id =2,
                   FirstName = "User",
                   LastName = "user",
                   Email = "user@gmail.com",
                   Username = "userUser",
                   Password = "6583122D691EAFAADB3583F0B0F122CA"
                },
            };

            //Proveriti kasnije UseCaseId
            var userUseCases = new List<UserUseCases>
            {
                new UserUseCases {
                    Id = 1,
                    UserId = 1,
                    UseCaseId = 1,
                },
                new UserUseCases {
                    Id = 2,
                    UserId = 1,
                    UseCaseId = 2,
                },
                new UserUseCases {
                    Id = 3,
                    UserId = 1,
                    UseCaseId = 3,
                },
                new UserUseCases {
                    Id = 4,
                    UserId = 1,
                    UseCaseId = 4,
                },

                 new UserUseCases {
                    Id = 5,
                    UserId = 2,
                    UseCaseId = 6,
                },
                new UserUseCases {
                    Id = 6,
                    UserId = 2,
                    UseCaseId = 7,
                },
                new UserUseCases {
                    Id = 7,
                    UserId = 2,
                    UseCaseId = 8,
                },
                new UserUseCases {
                    Id = 8,
                    UserId = 2,
                    UseCaseId = 9,
                },
                 new UserUseCases {
                    Id = 9,
                    UserId = 2,
                    UseCaseId = 10,
                },
                new UserUseCases {
                    Id = 10,
                    UserId = 2,
                    UseCaseId = 11,
                },
                new UserUseCases {
                    Id = 11,
                    UserId = 2,
                    UseCaseId = 12,
                },
                new UserUseCases {
                    Id = 12,
                    UserId = 2,
                    UseCaseId = 13,
                },
                new UserUseCases {
                    Id = 13,
                    UserId = 2,
                    UseCaseId = 3,
                },
                new UserUseCases {
                    Id = 14,
                    UserId = 1,
                    UseCaseId = 5,
                },
                new UserUseCases {
                    Id = 15,
                    UserId = 1,
                    UseCaseId = 6,
                },
                new UserUseCases {
                    Id = 16,
                    UserId = 1,
                    UseCaseId = 7,
                },
                new UserUseCases {
                    Id = 17,
                    UserId = 1,
                    UseCaseId = 8,
                },
                new UserUseCases {
                    Id = 18,
                    UserId = 1,
                    UseCaseId = 9,
                },
                new UserUseCases {
                    Id = 19,
                    UserId = 1,
                    UseCaseId = 10,

                },
            };

            var movies = new List<Movie>
            {
                new Movie {
                    Id = 1,
                    Title = "The Shawshank Redemption ",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    Duration = 142,
                    Image = "d72a304f-b6b0-466f-806d-505756825176.jpg"
                },
                new Movie {
                    Id = 2,
                    Title = "The Godfather",
                    Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                    Duration = 175,
                     Image = "6d5dd6aa-477a-4a6d-9e32-1133607881c5.jpg"
                },
                new Movie {
                    Id = 3,
                    Title = "The Dark Knight",
                    Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                    Duration = 152,
                     Image = "38e87283-fa50-4509-8a34-0b92afda5cc2.jpg"
                },
                new Movie {
                    Id = 4,
                    Title = "12 Angry Men",
                    Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                    Duration = 96,
                     Image = "6d16d467-e8ac-4990-b5cd-1c3d103e82c0.jpg"
                },
                new Movie {
                    Id = 5,
                    Title = "Schindler's List",
                    Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                    Duration = 195,
                     Image = "9b263823-5bf0-41a2-8ff2-a6c6f873c43c.jpg"
                },
                new Movie {
                    Id = 6,
                    Title = "The Lord of the Rings: The Return of the King",
                    Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                    Duration = 201,
                    Image = "09459e52-bee9-4adc-8724-605b4f95fe62.jpg"
                },
                new Movie {
                    Id = 7,
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    Duration = 154,
                    Image = "fc2645ba-d817-4a60-8150-f3c66777361b.jpg"
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
                    MovieId = 1,
                    AuditoriumId = 2,
                    ScreeningTime = new DateTime (2020, 7, 2, 15, 0, 0)
                },
                new Screening {
                    Id = 3,
                    MovieId = 2,
                    AuditoriumId = 2,
                    ScreeningTime = new DateTime (2020, 7, 2, 17, 0, 0)
                },
                new Screening {
                    Id = 4,
                    MovieId = 3,
                    AuditoriumId = 2,
                    ScreeningTime = new DateTime (2020, 7, 3, 20, 0, 0)
                },
            };


            var auditoriums = new List<Auditorium>
            {
                new Auditorium {
                    Id = 1,
                    Name = "Auditorium 1"
                },
                new Auditorium {
                    Id = 2,
                    Name = "Auditorium 2"
                },
            };

            var seats = new List<Seat>
            {
                new Seat
                {
                    Id = 1,
                    Number = 1,
                    AuditoriumId = 1
                },
                new Seat
                {
                    Id = 2,
                    Number = 2,
                    AuditoriumId = 1
                },
                new Seat
                {
                    Id = 3,
                    Number = 1,
                    AuditoriumId = 2
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
                   ScreeningId = 2
                },
            };


            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<UserUseCases>().HasData(userUseCases);
            modelBuilder.Entity<Movie>().HasData(movies);
            modelBuilder.Entity<Screening>().HasData(screening);
            modelBuilder.Entity<Auditorium>().HasData(auditoriums);
            modelBuilder.Entity<Seat>().HasData(seats);
            modelBuilder.Entity<Reservation>().HasData(reservations);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new ScreeningConfiguration());
            modelBuilder.ApplyConfiguration(new SeatConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Reservation>().ToTable("Reservations");

            modelBuilder.Entity<Screening>().HasIndex(p => new {  p.AuditoriumId, p.ScreeningTime }).IsUnique();
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
    }
}
