using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class updateonetoonerel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 37, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(3243));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 195, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(134));
        }
    }
}
