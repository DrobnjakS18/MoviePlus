using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class removeseatresseeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 2, 1, 2 });

            migrationBuilder.DeleteData(
                table: "SeatReserved",
                keyColumns: new[] { "SeatId", "ScreeningId", "ReservationId" },
                keyValues: new object[] { 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 177, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(959));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 173, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 177, DateTimeKind.Local).AddTicks(8546));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 628, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.InsertData(
                table: "SeatReserved",
                columns: new[] { "SeatId", "ScreeningId", "ReservationId", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(5117), null, true, false, null },
                    { 2, 1, 2, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(7115), null, true, false, null },
                    { 3, 3, 2, new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(7177), null, true, false, null }
                });

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
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 3, 54, 629, DateTimeKind.Local).AddTicks(1903));

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
    }
}
