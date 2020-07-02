using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class usecaseseeder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "AuditoriumId", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "MovieId", "ScreeningTime", "UpdatedAt" },
                values: new object[,]
                {
                    { 5, 2, new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(1176), null, true, false, 4, new DateTime(2020, 7, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 1, new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(1194), null, true, false, 6, new DateTime(2020, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 1, new DateTime(2020, 7, 2, 1, 40, 18, 330, DateTimeKind.Local).AddTicks(1212), null, true, false, 7, new DateTime(2020, 7, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

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

            migrationBuilder.InsertData(
                table: "UserUseCases",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "UpdatedAt", "UseCaseId", "UserId" },
                values: new object[,]
                {
                    { 18, new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(9001), null, true, false, null, 18, 1 },
                    { 17, new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8985), null, true, false, null, 17, 1 },
                    { 16, new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8977), null, true, false, null, 16, 1 },
                    { 15, new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8969), null, true, false, null, 15, 1 },
                    { 14, new DateTime(2020, 7, 2, 1, 40, 18, 328, DateTimeKind.Local).AddTicks(8961), null, true, false, null, 14, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 1, 40, 18, 324, DateTimeKind.Local).AddTicks(1186));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14);

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

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 41, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 34, DateTimeKind.Local).AddTicks(861));
        }
    }
}
