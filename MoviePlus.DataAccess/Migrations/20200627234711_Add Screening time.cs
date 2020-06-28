using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class AddScreeningtime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 865, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 865, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 865, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "MovieId", "ScreeningTime" },
                values: new object[] { new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(7343), 1, new DateTime(2020, 7, 2, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "MovieId", "ScreeningTime" },
                values: new object[] { new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(7405), 2, new DateTime(2020, 7, 2, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "AuditoriumId", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "MovieId", "ScreeningTime", "UpdatedAt" },
                values: new object[] { 4, 2, new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(7416), null, true, false, 3, new DateTime(2020, 7, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 865, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 865, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 865, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 865, DateTimeKind.Local).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 865, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 863, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 858, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 863, DateTimeKind.Local).AddTicks(8124));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4);

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
                columns: new[] { "CreatedAt", "MovieId", "ScreeningTime" },
                values: new object[] { new DateTime(2020, 6, 28, 0, 53, 33, 947, DateTimeKind.Local).AddTicks(8389), 3, new DateTime(2020, 7, 2, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "MovieId", "ScreeningTime" },
                values: new object[] { new DateTime(2020, 6, 28, 0, 53, 33, 947, DateTimeKind.Local).AddTicks(8473), 5, new DateTime(2020, 7, 3, 20, 0, 0, 0, DateTimeKind.Unspecified) });

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
        }
    }
}
