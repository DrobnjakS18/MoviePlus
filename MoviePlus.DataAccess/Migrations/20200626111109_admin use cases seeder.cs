using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class adminusecasesseeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 26, 13, 11, 8, 508, DateTimeKind.Local).AddTicks(8309), 1 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 26, 13, 11, 8, 508, DateTimeKind.Local).AddTicks(9150), 1 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 26, 13, 11, 8, 508, DateTimeKind.Local).AddTicks(9178), 1 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 26, 13, 11, 8, 508, DateTimeKind.Local).AddTicks(9182), 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 505, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 13, 11, 8, 508, DateTimeKind.Local).AddTicks(7610));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 794, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 794, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 794, DateTimeKind.Local).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 794, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 794, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 794, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 794, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 794, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 794, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 794, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(2085), 2 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(3074), 2 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(3102), 2 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(3106), 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 787, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 16, 11, 40, 793, DateTimeKind.Local).AddTicks(1068));
        }
    }
}
