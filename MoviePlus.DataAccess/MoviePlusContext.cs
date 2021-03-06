﻿using Microsoft.EntityFrameworkCore;
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
                    UserId = 1,
                    UseCaseId = 5,
                },
                new UserUseCases {
                    Id = 6,
                    UserId = 1,
                    UseCaseId = 6,
                },
                new UserUseCases {
                    Id = 7,
                    UserId = 1,
                    UseCaseId = 7,
                },
                new UserUseCases {
                    Id = 8,
                    UserId = 1,
                    UseCaseId = 8,
                },
                 new UserUseCases {
                    Id = 9,
                    UserId = 1,
                    UseCaseId = 9,
                },
                new UserUseCases {
                    Id = 10,
                    UserId = 1,
                    UseCaseId = 10,
                },
                new UserUseCases {
                    Id = 11,
                    UserId = 1,
                    UseCaseId = 11,
                },
                new UserUseCases {
                    Id = 12,
                    UserId = 1,
                    UseCaseId = 12,
                },
                new UserUseCases {
                    Id = 13,
                    UserId = 1,
                    UseCaseId = 13,
                },
                 new UserUseCases {
                    Id = 14,
                    UserId = 1,
                    UseCaseId = 14,
                },
                  new UserUseCases {
                    Id = 15,
                    UserId = 1,
                    UseCaseId = 15,
                },
                   new UserUseCases {
                    Id = 16,
                    UserId = 1,
                    UseCaseId = 16,
                },
                   new UserUseCases {
                    Id = 17,
                    UserId = 1,
                    UseCaseId = 17,
                },
                   new UserUseCases {
                    Id = 18,
                    UserId = 1,
                    UseCaseId = 18,
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

            var screening = new List<Screening>
            {
                new Screening {
                    Id = 1,
                    MovieId = 1,
                    AuditoriumId = 1,
                    ScreeningTime = new DateTime (2020, 7, 4, 15, 0, 0)
                },
                new Screening {
                    Id = 2,
                    MovieId = 2,
                    AuditoriumId = 2,
                    ScreeningTime = new DateTime (2020, 7, 2, 15, 0, 0)
                },
                new Screening {
                    Id = 3,
                    MovieId = 3,
                    AuditoriumId = 2,
                    ScreeningTime = new DateTime (2020, 7, 3, 15, 0, 0)
                },
                new Screening {
                    Id = 4,
                    MovieId = 4,
                    AuditoriumId = 1,
                    ScreeningTime = new DateTime (2020, 7, 6, 17, 0, 0)
                },
                new Screening {
                    Id = 5,
                    MovieId = 4,
                    AuditoriumId = 2,
                    ScreeningTime = new DateTime (2020, 7, 4, 17, 0, 0)
                },
                new Screening {
                    Id = 6,
                    MovieId = 6,
                    AuditoriumId = 1,
                    ScreeningTime = new DateTime (2020, 7, 5, 15, 0, 0)
                },
                new Screening {
                    Id = 7,
                    MovieId = 7,
                    AuditoriumId = 1,
                    ScreeningTime = new DateTime (2020, 7, 2, 20, 0, 0)
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
                 new Auditorium {
                    Id = 3,
                    Name = "Auditorium 3"
                },
                  new Auditorium {
                    Id = 4,
                    Name = "Auditorium 4"
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
                    Number = 3,
                    AuditoriumId = 1
                },
                new Seat
                {
                    Id = 4,
                    Number = 4,
                    AuditoriumId = 1
                },
                new Seat
                {
                    Id = 5,
                    Number = 5,
                    AuditoriumId = 1
                },
                new Seat
                {
                    Id = 6,
                    Number = 6,
                    AuditoriumId = 1
                },
                new Seat
                {
                    Id = 7,
                    Number = 7,
                    AuditoriumId = 1
                },
                new Seat
                {
                    Id = 8,
                    Number = 8,
                    AuditoriumId = 1
                },
                new Seat
                {
                    Id = 9,
                    Number = 9,
                    AuditoriumId = 1
                },
                new Seat
                {
                    Id = 10,
                    Number = 10,
                    AuditoriumId = 1
                },
                 new Seat
                {
                    Id = 11,
                    Number = 1,
                    AuditoriumId = 2
                },
                new Seat
                {
                    Id = 12,
                    Number = 2,
                    AuditoriumId = 2
                },
                new Seat
                {
                    Id = 13,
                    Number = 3,
                    AuditoriumId = 2
                },
                new Seat
                {
                    Id = 14,
                    Number = 4,
                    AuditoriumId = 2
                },
                new Seat
                {
                    Id = 15,
                    Number = 5,
                    AuditoriumId = 2
                },
                new Seat
                {
                    Id = 16,
                    Number = 6,
                    AuditoriumId = 2
                },
                new Seat
                {
                    Id = 17,
                    Number = 7,
                    AuditoriumId = 2
                },
                new Seat
                {
                    Id = 18,
                    Number = 8,
                    AuditoriumId = 2
                },
                new Seat
                {
                    Id = 19,
                    Number = 9,
                    AuditoriumId = 2
                },
                new Seat
                {
                    Id = 20,
                    Number = 10,
                    AuditoriumId = 2
                },
                 new Seat
                {
                    Id = 21,
                    Number = 1,
                    AuditoriumId = 3
                },
                new Seat
                {
                    Id = 22,
                    Number = 2,
                    AuditoriumId = 3
                },
                new Seat
                {
                    Id = 23,
                    Number = 3,
                    AuditoriumId = 3
                },
                new Seat
                {
                    Id = 24,
                    Number = 4,
                    AuditoriumId = 3
                },
                new Seat
                {
                    Id = 25,
                    Number = 5,
                    AuditoriumId = 3
                },
                new Seat
                {
                    Id = 26,
                    Number = 6,
                    AuditoriumId = 3
                },
                new Seat
                {
                    Id = 27,
                    Number = 7,
                    AuditoriumId = 3
                },
                new Seat
                {
                    Id = 28,
                    Number = 8,
                    AuditoriumId = 3
                },
                new Seat
                {
                    Id = 29,
                    Number = 9,
                    AuditoriumId = 3
                },
                new Seat
                {
                    Id = 30,
                    Number = 10,
                    AuditoriumId = 3
                },
                 new Seat
                {
                    Id = 31,
                    Number = 1,
                    AuditoriumId = 4
                },
                new Seat
                {
                    Id = 32,
                    Number = 2,
                    AuditoriumId = 4
                },
                new Seat
                {
                    Id = 33,
                    Number = 3,
                    AuditoriumId = 4
                },
                new Seat
                {
                    Id = 34,
                    Number = 4,
                    AuditoriumId = 4
                },
                new Seat
                {
                    Id = 35,
                    Number = 5,
                    AuditoriumId = 4
                },
                new Seat
                {
                    Id = 36,
                    Number = 6,
                    AuditoriumId = 4
                },
                new Seat
                {
                    Id = 37,
                    Number = 7,
                    AuditoriumId = 4
                },
                new Seat
                {
                    Id = 38,
                    Number = 8,
                    AuditoriumId = 4
                },
                new Seat
                {
                    Id = 39,
                    Number = 9,
                    AuditoriumId = 4
                },
                new Seat
                {
                    Id = 40,
                    Number = 10,
                    AuditoriumId = 4
                },
            };

            //var reservations = new List<Reservation>
            //{
            //    new Reservation {
            //       Id = 1,
            //       UserId = 1,
            //       ScreeningId = 1
            //    },
            //    new Reservation {
            //       Id = 2,
            //       UserId = 1,
            //       ScreeningId = 2
            //    },
            //     new Reservation {
            //       Id = 3,
            //       UserId = 2,
            //       ScreeningId = 1
            //    },
            //      new Reservation {
            //       Id = 4,
            //       UserId = 2,
            //       ScreeningId = 3
            //    },
            //};

            //var seatReservations = new List<SeatReserved>
            //{
            //    new SeatReserved {
            //        ReservationId = 1,
            //        SeatId = 1,
            //        ScreeningId = 1
            //    },
            //     new SeatReserved {
            //        ReservationId = 2,
            //        SeatId = 2,
            //        ScreeningId = 1
            //    },
            //      new SeatReserved {
            //        ReservationId = 2,
            //        SeatId = 3,
            //        ScreeningId = 3
            //    }
            //};


            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<UserUseCases>().HasData(userUseCases);
            modelBuilder.Entity<Movie>().HasData(movies);
            modelBuilder.Entity<Screening>().HasData(screening);
            modelBuilder.Entity<Auditorium>().HasData(auditoriums);
            modelBuilder.Entity<Seat>().HasData(seats);
            //modelBuilder.Entity<Reservation>().HasData(reservations);
            //modelBuilder.Entity<SeatReserved>().HasData(seatReservations);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new ScreeningConfiguration());
            modelBuilder.ApplyConfiguration(new SeatConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Reservation>().ToTable("Reservations");

            modelBuilder.Entity<User>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Movie>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<UserUseCases>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Screening>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Auditorium>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Reservation>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Seat>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<SeatReserved>().HasQueryFilter(x => !x.IsDeleted);

            modelBuilder.Entity<Screening>().HasIndex(p => new {  p.AuditoriumId, p.ScreeningTime }).IsUnique();
            modelBuilder.Entity<SeatReserved>().HasKey(s => new { s.SeatId, s.ScreeningId, s.ReservationId });
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

        public DbSet<SeatReserved> SeatReserved { get; set; }
    }
}
