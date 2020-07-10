using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class Auditorium4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.InsertData(
                table: "Auditoriums",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(4018), null, true, false, "Auditorium 4", null });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 950, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 951, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 44, 3, 943, DateTimeKind.Local).AddTicks(9543));

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "AuditoriumId", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "Number", "UpdatedAt" },
                values: new object[,]
                {
                    { 31, 4, new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7241), null, true, false, 1, null },
                    { 32, 4, new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7251), null, true, false, 2, null },
                    { 33, 4, new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7267), null, true, false, 3, null },
                    { 34, 4, new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7285), null, true, false, 4, null },
                    { 35, 4, new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7304), null, true, false, 5, null },
                    { 36, 4, new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7316), null, true, false, 6, null },
                    { 37, 4, new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7528), null, true, false, 7, null },
                    { 38, 4, new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7561), null, true, false, 8, null },
                    { 39, 4, new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7573), null, true, false, 9, null },
                    { 40, 4, new DateTime(2020, 7, 10, 23, 44, 3, 952, DateTimeKind.Local).AddTicks(7582), null, true, false, 10, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(5544));

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
                table: "Seats",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 23, 10, 16, 948, DateTimeKind.Local).AddTicks(7694));

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
        }
    }
}
