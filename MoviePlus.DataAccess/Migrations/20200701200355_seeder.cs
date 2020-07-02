using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "MovieId", "ScreeningTime" },
                values: new object[] { new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(8023), 2, new DateTime(2020, 7, 2, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "MovieId", "ScreeningTime" },
                values: new object[] { new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(8082), 3, new DateTime(2020, 7, 3, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuditoriumId", "CreatedAt", "MovieId", "ScreeningTime" },
                values: new object[] { 1, new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(8093), 4, new DateTime(2020, 7, 6, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 1, 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 2, 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 3, 3, 2 },
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuditoriumId", "CreatedAt", "Number" },
                values: new object[] { 1, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1787), 6 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuditoriumId", "CreatedAt", "Number" },
                values: new object[] { 1, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1796), 7 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuditoriumId", "CreatedAt", "Number" },
                values: new object[] { 1, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1804), 8 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuditoriumId", "CreatedAt", "Number" },
                values: new object[] { 1, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1811), 9 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuditoriumId", "CreatedAt", "Number" },
                values: new object[] { 1, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1822), 10 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "AuditoriumId", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "Number", "UpdatedAt" },
                values: new object[,]
                {
                    { 11, 2, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1831), null, true, false, 1, null },
                    { 15, 2, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1861), null, true, false, 5, null },
                    { 17, 2, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1876), null, true, false, 7, null },
                    { 12, 2, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1838), null, true, false, 2, null },
                    { 13, 2, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1846), null, true, false, 3, null },
                    { 14, 2, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1854), null, true, false, 4, null },
                    { 18, 2, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1887), null, true, false, 8, null },
                    { 19, 2, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1896), null, true, false, 9, null },
                    { 20, 2, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1903), null, true, false, 10, null },
                    { 16, 2, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1869), null, true, false, 6, null }
                });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 623, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 627, DateTimeKind.Local).AddTicks(9389));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "MovieId", "ScreeningTime" },
                values: new object[] { new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(2699), 1, new DateTime(2020, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "MovieId", "ScreeningTime" },
                values: new object[] { new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(2786), 2, new DateTime(2020, 7, 2, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuditoriumId", "CreatedAt", "MovieId", "ScreeningTime" },
                values: new object[] { 2, new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(2804), 3, new DateTime(2020, 7, 3, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 1, 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 917, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 2, 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 917, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 3, 3, 2 },
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 917, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuditoriumId", "CreatedAt", "Number" },
                values: new object[] { 2, new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(6799), 1 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuditoriumId", "CreatedAt", "Number" },
                values: new object[] { 2, new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(6809), 2 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuditoriumId", "CreatedAt", "Number" },
                values: new object[] { 2, new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(6818), 3 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuditoriumId", "CreatedAt", "Number" },
                values: new object[] { 2, new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(6828), 4 });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuditoriumId", "CreatedAt", "Number" },
                values: new object[] { 2, new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(6840), 5 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 910, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(2717));
        }
    }
}
