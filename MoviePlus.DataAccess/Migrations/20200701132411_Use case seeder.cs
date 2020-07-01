using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class Usecaseseeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(2804));

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
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 24, 10, 916, DateTimeKind.Local).AddTicks(6840));

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

            migrationBuilder.InsertData(
                table: "UserUseCases",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "UpdatedAt", "UseCaseId", "UserId" },
                values: new object[,]
                {
                    { 24, new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5592), null, true, false, null, 15, 1 },
                    { 23, new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5584), null, true, false, null, 14, 1 },
                    { 22, new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5575), null, true, false, null, 13, 1 },
                    { 21, new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5567), null, true, false, null, 12, 1 },
                    { 20, new DateTime(2020, 7, 1, 15, 24, 10, 915, DateTimeKind.Local).AddTicks(5559), null, true, false, null, 11, 1 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 563, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 563, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 563, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 563, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 1, 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 563, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 2, 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 563, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 3, 3, 2 },
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 563, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 561, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 557, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 54, 25, 561, DateTimeKind.Local).AddTicks(7935));
        }
    }
}
