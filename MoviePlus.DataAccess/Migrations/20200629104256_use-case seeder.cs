using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class usecaseseeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "UserUseCases",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "UpdatedAt", "UseCaseId", "UserId" },
                values: new object[,]
                {
                    { 15, new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1748), null, true, false, null, 6, 1 },
                    { 19, new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1762), null, true, false, null, 10, 1 },
                    { 18, new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1758), null, true, false, null, 9, 1 },
                    { 17, new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1754), null, true, false, null, 8, 1 },
                    { 16, new DateTime(2020, 6, 29, 12, 42, 56, 199, DateTimeKind.Local).AddTicks(1751), null, true, false, null, 7, 1 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 398, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(6548));
        }
    }
}
