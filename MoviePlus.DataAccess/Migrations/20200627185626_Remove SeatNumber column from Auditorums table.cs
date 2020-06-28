using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class RemoveSeatNumbercolumnfromAuditorumstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatNumbers",
                table: "Auditoriums");

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 371, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 371, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 371, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 371, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 371, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 371, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 371, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 371, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 371, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 370, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 364, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 20, 56, 25, 369, DateTimeKind.Local).AddTicks(9135));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeatNumbers",
                table: "Auditoriums",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SeatNumbers" },
                values: new object[] { new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(9768), 20 });

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SeatNumbers" },
                values: new object[] { new DateTime(2020, 6, 26, 14, 36, 26, 720, DateTimeKind.Local).AddTicks(594), 30 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 720, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 720, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 720, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 720, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 720, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 720, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 720, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 720, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 720, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 715, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(3981));
        }
    }
}
