using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class Uniqueindex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Screenings_AuditoriumId",
                table: "Screenings");

            migrationBuilder.DropIndex(
                name: "IX_Screenings_MovieId_AuditoriumId_ScreeningTime",
                table: "Screenings");

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 947, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 948, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 946, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 947, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 947, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 947, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 947, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 947, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 947, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 948, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 948, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 948, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 947, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 947, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 947, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 948, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 948, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 948, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 948, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 948, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 948, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 946, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 946, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 946, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 946, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 941, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 53, 33, 946, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MovieId",
                table: "Screenings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_AuditoriumId_ScreeningTime",
                table: "Screenings",
                columns: new[] { "AuditoriumId", "ScreeningTime" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Screenings_MovieId",
                table: "Screenings");

            migrationBuilder.DropIndex(
                name: "IX_Screenings_AuditoriumId_ScreeningTime",
                table: "Screenings");

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 709, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 709, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 709, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 709, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 709, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 709, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 709, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 709, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 707, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 708, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 702, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 0, 3, 49, 707, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_AuditoriumId",
                table: "Screenings",
                column: "AuditoriumId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MovieId_AuditoriumId_ScreeningTime",
                table: "Screenings",
                columns: new[] { "MovieId", "AuditoriumId", "ScreeningTime" });
        }
    }
}
