using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class Reservationseeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 1, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 1, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 1, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 7, 1, 2, 32, 28, 1, DateTimeKind.Local).AddTicks(7033), 1 });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "ScreeningId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 3, new DateTime(2020, 7, 1, 2, 32, 28, 1, DateTimeKind.Local).AddTicks(7078), null, true, false, 1, null, 2 },
                    { 4, new DateTime(2020, 7, 1, 2, 32, 28, 1, DateTimeKind.Local).AddTicks(7088), null, true, false, 3, null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ScreeningTime" },
                values: new object[] { new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(9407), new DateTime(2020, 7, 4, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ScreeningTime" },
                values: new object[] { new DateTime(2020, 7, 1, 2, 32, 28, 1, DateTimeKind.Local).AddTicks(1455), new DateTime(2020, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 1, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 1, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 1, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 1, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 1, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 27, 995, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 2, 32, 28, 0, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations");

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 847, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 847, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 847, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2020, 6, 29, 23, 49, 33, 847, DateTimeKind.Local).AddTicks(5377), 2 });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ScreeningTime" },
                values: new object[] { new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(7424), new DateTime(2020, 7, 1, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ScreeningTime" },
                values: new object[] { new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(9520), new DateTime(2020, 7, 2, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 847, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 847, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 847, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 841, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 23, 49, 33, 846, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId",
                unique: true);
        }
    }
}
