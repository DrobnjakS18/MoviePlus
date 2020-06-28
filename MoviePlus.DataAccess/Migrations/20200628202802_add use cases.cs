using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class addusecases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "UserUseCases",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "UpdatedAt", "UseCaseId", "UserId" },
                values: new object[,]
                {
                    { 12, new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1281), null, true, false, null, 13, 2 },
                    { 11, new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1262), null, true, false, null, 12, 2 },
                    { 10, new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1239), null, true, false, null, 11, 2 },
                    { 9, new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1211), null, true, false, null, 10, 2 },
                    { 8, new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1190), null, true, false, null, 9, 2 },
                    { 7, new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1166), null, true, false, null, 8, 2 },
                    { 6, new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1141), null, true, false, null, 7, 2 },
                    { 5, new DateTime(2020, 6, 28, 22, 28, 1, 894, DateTimeKind.Local).AddTicks(1104), null, true, false, null, 6, 2 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12);

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
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 1, 47, 10, 864, DateTimeKind.Local).AddTicks(7416));

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
    }
}
