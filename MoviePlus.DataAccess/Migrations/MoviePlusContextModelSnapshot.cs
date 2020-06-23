﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviePlus.DataAccess;

namespace MoviePlus.DataAccess.Migrations
{
    [DbContext(typeof(MoviePlusContext))]
    partial class MoviePlusContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("ScreeningId")
                        .HasColumnType("int");

                    b.Property<int?>("SeatId")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumbers")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ScreeningId");

                    b.HasIndex("SeatId");

                    b.ToTable("Auditoriums");
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ScreeningId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ScreeningId");

                    b.ToTable("Movies");
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

                    b.Property<int?>("SeatReservedId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScreeningId");

                    b.HasIndex("SeatReservedId");

                    b.ToTable("Reservations");
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

                    b.Property<int?>("SeatReservedId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SeatReservedId");

                    b.ToTable("Screenings");
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

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.Property<int?>("SeatReservedId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SeatReservedId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("MoviePlus.Domain.SeatReserved", b =>
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

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("int");

                    b.Property<int>("SeatId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SeatsReserved");
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 6, 23, 16, 42, 58, 680, DateTimeKind.Local).AddTicks(8677),
                            Email = "admin@gmail.com",
                            FirstName = "Admin",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Admin",
                            Password = "pass123",
                            Username = "adminAdmin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 6, 23, 16, 42, 58, 684, DateTimeKind.Local).AddTicks(6281),
                            Email = "user@gmail.com",
                            FirstName = "User",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "user",
                            Password = "pass123",
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
                });

            modelBuilder.Entity("MoviePlus.Domain.Auditorium", b =>
                {
                    b.HasOne("MoviePlus.Domain.Screening", null)
                        .WithMany("Auditoriums")
                        .HasForeignKey("ScreeningId");

                    b.HasOne("MoviePlus.Domain.Seat", null)
                        .WithMany("Auditoriums")
                        .HasForeignKey("SeatId");
                });

            modelBuilder.Entity("MoviePlus.Domain.Movie", b =>
                {
                    b.HasOne("MoviePlus.Domain.Screening", null)
                        .WithMany("Movies")
                        .HasForeignKey("ScreeningId");
                });

            modelBuilder.Entity("MoviePlus.Domain.Reservation", b =>
                {
                    b.HasOne("MoviePlus.Domain.Screening", "Screening")
                        .WithMany()
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviePlus.Domain.SeatReserved", null)
                        .WithMany("Reservations")
                        .HasForeignKey("SeatReservedId");
                });

            modelBuilder.Entity("MoviePlus.Domain.Screening", b =>
                {
                    b.HasOne("MoviePlus.Domain.SeatReserved", null)
                        .WithMany("Screenings")
                        .HasForeignKey("SeatReservedId");
                });

            modelBuilder.Entity("MoviePlus.Domain.Seat", b =>
                {
                    b.HasOne("MoviePlus.Domain.SeatReserved", null)
                        .WithMany("Seats")
                        .HasForeignKey("SeatReservedId");
                });

            modelBuilder.Entity("MoviePlus.Domain.User", b =>
                {
                    b.HasOne("MoviePlus.Domain.Reservation", null)
                        .WithMany("Users")
                        .HasForeignKey("ReservationId");
                });

            modelBuilder.Entity("MoviePlus.Domain.UserUseCases", b =>
                {
                    b.HasOne("MoviePlus.Domain.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
