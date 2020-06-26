using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class seederuserpasswordhash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 14, 36, 26, 720, DateTimeKind.Local).AddTicks(594));

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
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 6, 26, 14, 36, 26, 715, DateTimeKind.Local).AddTicks(5554), "A12450CFF6FB7A97C975BFB7FCBB8F7E" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 6, 26, 14, 36, 26, 719, DateTimeKind.Local).AddTicks(3981), "6583122D691EAFAADB3583F0B0F122CA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 508, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 509, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 508, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 508, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 508, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 508, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 6, 26, 13, 11, 8, 505, DateTimeKind.Local).AddTicks(1623), "pass123" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2020, 6, 26, 13, 11, 8, 508, DateTimeKind.Local).AddTicks(7610), "pass123" });
        }
    }
}
