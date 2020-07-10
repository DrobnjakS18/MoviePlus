using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class Auditorium3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeatReserved_Reservations_ReservationId",
                table: "SeatReserved");

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.InsertData(
                table: "Auditoriums",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(5544), null, true, false, "Auditorium 3", null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 947, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 942, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "AuditoriumId", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "Number", "UpdatedAt" },
                values: new object[,]
                {
                    { 21, 3, new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7635), null, true, false, 1, null },
                    { 22, 3, new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7641), null, true, false, 2, null },
                    { 23, 3, new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7648), null, true, false, 3, null },
                    { 24, 3, new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7654), null, true, false, 4, null },
                    { 25, 3, new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7661), null, true, false, 5, null },
                    { 26, 3, new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7668), null, true, false, 6, null },
                    { 27, 3, new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7674), null, true, false, 7, null },
                    { 28, 3, new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7681), null, true, false, 8, null },
                    { 29, 3, new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7687), null, true, false, 9, null },
                    { 30, 3, new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7694), null, true, false, 10, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SeatReserved_Reservations_ReservationId",
                table: "SeatReserved",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeatReserved_Reservations_ReservationId",
                table: "SeatReserved");

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 329, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 329, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 329, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 329, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 329, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 329, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 329, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 329, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 324, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.AddForeignKey(
                name: "FK_SeatReserved_Reservations_ReservationId",
                table: "SeatReserved",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
