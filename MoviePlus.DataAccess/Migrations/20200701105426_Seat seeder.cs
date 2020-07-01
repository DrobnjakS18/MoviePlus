using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class Seatseeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedAt", "Number" },
                values: new object[] { new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9889), 3 });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "AuditoriumId", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "Number", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, 1, new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9899), null, true, false, 4, null },
                    { 7, 2, new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9925), null, true, false, 2, null },
                    { 9, 2, new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9939), null, true, false, 4, null },
                    { 5, 1, new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9906), null, true, false, 5, null },
                    { 6, 2, new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9917), null, true, false, 1, null },
                    { 10, 2, new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9948), null, true, false, 5, null },
                    { 8, 2, new DateTime(2020, 7, 1, 12, 54, 25, 562, DateTimeKind.Local).AddTicks(9932), null, true, false, 3, null }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 783, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 783, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 783, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 783, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 1, 1, 1 },
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 783, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 2, 1, 2 },
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 783, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 3, 3, 2 },
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 783, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 783, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 783, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Number" },
                values: new object[] { new DateTime(2020, 7, 1, 12, 51, 58, 783, DateTimeKind.Local).AddTicks(1653), 1 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 782, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 777, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 781, DateTimeKind.Local).AddTicks(9878));
        }
    }
}
