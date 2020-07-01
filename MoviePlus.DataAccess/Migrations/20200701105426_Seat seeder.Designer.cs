﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviePlus.DataAccess;

namespace MoviePlus.DataAccess.Migrations
{
    [DbContext(typeof(MoviePlusContext))]
    [Migration("20200701105426_Seat seeder")]
    partial class Seatseeder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoviePlus.Domain.AuditLogger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Actor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("UseCaseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuditLogger");
                });

            modelBuilder.Entity("MoviePlus.Domain.Auditorium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Auditoriums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(7008),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Auditorium 1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(7649),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Auditorium 2"
                        });
                });

            modelBuilder.Entity("MoviePlus.Domain.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1500)")
                        .HasMaxLength(1500);

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Description")
                        .IsUnique();

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(1145),
                            Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                            Duration = 142,
                            Image = "d72a304f-b6b0-466f-806d-505756825176.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            Title = "The Shawshank Redemption "
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(3479),
                            Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                            Duration = 175,
                            Image = "6d5dd6aa-477a-4a6d-9e32-1133607881c5.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            Title = "The Godfather"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(3559),
                            Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                            Duration = 152,
                            Image = "38e87283-fa50-4509-8a34-0b92afda5cc2.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(3571),
                            Description = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                            Duration = 96,
                            Image = "6d16d467-e8ac-4990-b5cd-1c3d103e82c0.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            Title = "12 Angry Men"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(3578),
                            Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                            Duration = 195,
                            Image = "9b263823-5bf0-41a2-8ff2-a6c6f873c43c.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            Title = "Schindler's List"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(3590),
                            Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                            Duration = 201,
                            Image = "09459e52-bee9-4adc-8724-605b4f95fe62.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            Title = "The Lord of the Rings: The Return of the King"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(3598),
                            Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                            Duration = 154,
                            Image = "fc2645ba-d817-4a60-8150-f3c66777361b.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            Title = "Pulp Fiction"
                        });
                });

            modelBuilder.Entity("MoviePlus.Domain.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScreeningId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 563, DateTimeKind.Local).AddTicks(788),
                            IsActive = true,
                            IsDeleted = false,
                            ScreeningId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 563, DateTimeKind.Local).AddTicks(2226),
                            IsActive = true,
                            IsDeleted = false,
                            ScreeningId = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 563, DateTimeKind.Local).AddTicks(2278),
                            IsActive = true,
                            IsDeleted = false,
                            ScreeningId = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 563, DateTimeKind.Local).AddTicks(2289),
                            IsActive = true,
                            IsDeleted = false,
                            ScreeningId = 3,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("MoviePlus.Domain.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuditoriumId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScreeningTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("AuditoriumId", "ScreeningTime")
                        .IsUnique();

                    b.ToTable("Screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuditoriumId = 1,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(4327),
                            IsActive = true,
                            IsDeleted = false,
                            MovieId = 1,
                            ScreeningTime = new DateTime(2020, 7, 4, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            AuditoriumId = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(6205),
                            IsActive = true,
                            IsDeleted = false,
                            MovieId = 1,
                            ScreeningTime = new DateTime(2020, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            AuditoriumId = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(6264),
                            IsActive = true,
                            IsDeleted = false,
                            MovieId = 2,
                            ScreeningTime = new DateTime(2020, 7, 2, 17, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            AuditoriumId = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(6275),
                            IsActive = true,
                            IsDeleted = false,
                            MovieId = 3,
                            ScreeningTime = new DateTime(2020, 7, 3, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MoviePlus.Domain.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuditoriumId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuditoriumId");

                    b.ToTable("Seats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuditoriumId = 1,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(8409),
                            IsActive = true,
                            IsDeleted = false,
                            Number = 1
                        },
                        new
                        {
                            Id = 2,
                            AuditoriumId = 1,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9842),
                            IsActive = true,
                            IsDeleted = false,
                            Number = 2
                        },
                        new
                        {
                            Id = 3,
                            AuditoriumId = 1,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9889),
                            IsActive = true,
                            IsDeleted = false,
                            Number = 3
                        },
                        new
                        {
                            Id = 4,
                            AuditoriumId = 1,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9899),
                            IsActive = true,
                            IsDeleted = false,
                            Number = 4
                        },
                        new
                        {
                            Id = 5,
                            AuditoriumId = 1,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9906),
                            IsActive = true,
                            IsDeleted = false,
                            Number = 5
                        },
                        new
                        {
                            Id = 6,
                            AuditoriumId = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9917),
                            IsActive = true,
                            IsDeleted = false,
                            Number = 1
                        },
                        new
                        {
                            Id = 7,
                            AuditoriumId = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9925),
                            IsActive = true,
                            IsDeleted = false,
                            Number = 2
                        },
                        new
                        {
                            Id = 8,
                            AuditoriumId = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9932),
                            IsActive = true,
                            IsDeleted = false,
                            Number = 3
                        },
                        new
                        {
                            Id = 9,
                            AuditoriumId = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9939),
                            IsActive = true,
                            IsDeleted = false,
                            Number = 4
                        },
                        new
                        {
                            Id = 10,
                            AuditoriumId = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9948),
                            IsActive = true,
                            IsDeleted = false,
                            Number = 5
                        });
                });

            modelBuilder.Entity("MoviePlus.Domain.SeatReserved", b =>
                {
                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("SeatId", "ScreeningId", "ReservationId");

                    b.HasIndex("ReservationId");

                    b.HasIndex("ScreeningId");

                    b.ToTable("SeatReserved");

                    b.HasData(
                        new
                        {
                            SeatId = 1,
                            ScreeningId = 1,
                            ReservationId = 1,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 563, DateTimeKind.Local).AddTicks(3703),
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            SeatId = 2,
                            ScreeningId = 1,
                            ReservationId = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 563, DateTimeKind.Local).AddTicks(5491),
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            SeatId = 3,
                            ScreeningId = 3,
                            ReservationId = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 563, DateTimeKind.Local).AddTicks(5549),
                            IsActive = true,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("MoviePlus.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 557, DateTimeKind.Local).AddTicks(3915),
                            Email = "admin@gmail.com",
                            FirstName = "Admin",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Admin",
                            Password = "A12450CFF6FB7A97C975BFB7FCBB8F7E",
                            Username = "adminAdmin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 561, DateTimeKind.Local).AddTicks(7935),
                            Email = "user@gmail.com",
                            FirstName = "User",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "user",
                            Password = "6583122D691EAFAADB3583F0B0F122CA",
                            Username = "userUser"
                        });
                });

            modelBuilder.Entity("MoviePlus.Domain.UserUseCases", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UseCaseId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserUseCases");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 561, DateTimeKind.Local).AddTicks(8830),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(167),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(219),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(229),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 4,
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(236),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 6,
                            UserId = 2
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(249),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 7,
                            UserId = 2
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(257),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 8,
                            UserId = 2
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(264),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 9,
                            UserId = 2
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(271),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 10,
                            UserId = 2
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(282),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 11,
                            UserId = 2
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(290),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 12,
                            UserId = 2
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(297),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 13,
                            UserId = 2
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(304),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 3,
                            UserId = 2
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(310),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 5,
                            UserId = 1
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(317),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 6,
                            UserId = 1
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(324),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 7,
                            UserId = 1
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(331),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 8,
                            UserId = 1
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(340),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 9,
                            UserId = 1
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(348),
                            IsActive = true,
                            IsDeleted = false,
                            UseCaseId = 10,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("MoviePlus.Domain.Reservation", b =>
                {
                    b.HasOne("MoviePlus.Domain.Screening", "Screening")
                        .WithMany("Reservations")
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviePlus.Domain.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MoviePlus.Domain.Screening", b =>
                {
                    b.HasOne("MoviePlus.Domain.Auditorium", "Auditorium")
                        .WithMany("Screenings")
                        .HasForeignKey("AuditoriumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviePlus.Domain.Movie", "Movie")
                        .WithMany("Screenings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MoviePlus.Domain.Seat", b =>
                {
                    b.HasOne("MoviePlus.Domain.Auditorium", "Auditorium")
                        .WithMany("Seats")
                        .HasForeignKey("AuditoriumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MoviePlus.Domain.SeatReserved", b =>
                {
                    b.HasOne("MoviePlus.Domain.Reservation", "Reservation")
                        .WithMany("SeatReserveds")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MoviePlus.Domain.Screening", "Screening")
                        .WithMany("SeatReserveds")
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MoviePlus.Domain.Seat", "Seat")
                        .WithMany("SeatReserveds")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("MoviePlus.Domain.UserUseCases", b =>
                {
                    b.HasOne("MoviePlus.Domain.User", "Users")
                        .WithMany("UserUseCases")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
