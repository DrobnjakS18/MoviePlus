using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class SeatReservedcompositekey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SeatReserved",
                table: "SeatReserved");

            migrationBuilder.DropIndex(
                name: "IX_SeatReserved_SeatId",
                table: "SeatReserved");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SeatReserved");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeatReserved",
                table: "SeatReserved",
                columns: new[] { "SeatId", "ScreeningId", "ReservationId" });

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
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 51, 58, 783, DateTimeKind.Local).AddTicks(1653));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SeatReserved",
                table: "SeatReserved");

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

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SeatReserved",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeatReserved",
                table: "SeatReserved",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 196, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 196, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 196, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 196, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.InsertData(
                table: "SeatReserved",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "ReservationId", "ScreeningId", "SeatId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 1, 12, 29, 24, 196, DateTimeKind.Local).AddTicks(3061), null, true, false, 1, 1, 1, null },
                    { 2, new DateTime(2020, 7, 1, 12, 29, 24, 196, DateTimeKind.Local).AddTicks(4898), null, true, false, 2, 1, 2, null },
                    { 3, new DateTime(2020, 7, 1, 12, 29, 24, 196, DateTimeKind.Local).AddTicks(4999), null, true, false, 2, 3, 3, null }
                });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 196, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 196, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 194, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 195, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 190, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 12, 29, 24, 194, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.CreateIndex(
                name: "IX_SeatReserved_SeatId",
                table: "SeatReserved",
                column: "SeatId");
        }
    }
}
