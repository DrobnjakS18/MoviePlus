using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class addusecace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 710, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 710, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 710, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 710, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 710, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 710, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 710, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 710, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 710, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 711, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 711, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 711, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 710, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 710, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 710, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 710, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 710, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 711, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 711, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 711, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 711, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 711, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 709, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 709, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 709, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 709, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 709, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 709, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 709, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 709, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 709, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 709, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 709, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 709, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.InsertData(
                table: "UserUseCases",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "UpdatedAt", "UseCaseId", "UserId" },
                values: new object[] { 13, new DateTime(2020, 6, 28, 22, 35, 46, 709, DateTimeKind.Local).AddTicks(9235), null, true, false, null, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 704, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 35, 46, 709, DateTimeKind.Local).AddTicks(6713));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 895, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 895, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 895, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 895, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 895, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 895, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 895, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 895, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 895, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 895, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 895, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 893, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 888, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 22, 28, 1, 893, DateTimeKind.Local).AddTicks(5580));
        }
    }
}
