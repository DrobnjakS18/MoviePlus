using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class adminusecases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13);

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

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.InsertData(
                table: "UserUseCases",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "UpdatedAt", "UseCaseId", "UserId" },
                values: new object[,]
                {
                    { 7, new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5772), null, true, false, null, 7, 1 },
                    { 8, new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5783), null, true, false, null, 8, 1 },
                    { 9, new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5794), null, true, false, null, 9, 1 },
                    { 10, new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5811), null, true, false, null, 10, 1 },
                    { 11, new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5825), null, true, false, null, 11, 1 },
                    { 12, new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5837), null, true, false, null, 12, 1 },
                    { 13, new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5849), null, true, false, null, 13, 1 },
                    { 5, new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5737), null, true, false, null, 5, 1 },
                    { 6, new DateTime(2020, 7, 1, 23, 25, 21, 40, DateTimeKind.Local).AddTicks(5759), null, true, false, null, 6, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 23, 25, 21, 34, DateTimeKind.Local).AddTicks(861));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "ScreeningId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(1640), null, true, false, 1, null, 1 },
                    { 2, new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(2993), null, true, false, 2, null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 177, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.InsertData(
                table: "UserUseCases",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "UpdatedAt", "UseCaseId", "UserId" },
                values: new object[,]
                {
                    { 22, new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1146), null, true, false, null, 13, 1 },
                    { 14, new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(979), null, true, false, null, 5, 1 },
                    { 15, new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(986), null, true, false, null, 6, 1 },
                    { 16, new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(992), null, true, false, null, 7, 1 },
                    { 17, new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1104), null, true, false, null, 8, 1 },
                    { 21, new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1139), null, true, false, null, 12, 1 },
                    { 23, new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1153), null, true, false, null, 14, 1 },
                    { 24, new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1159), null, true, false, null, 15, 1 },
                    { 19, new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1126), null, true, false, null, 10, 1 },
                    { 20, new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1132), null, true, false, null, 11, 1 },
                    { 18, new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(1118), null, true, false, null, 9, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 22, 7, 2, 173, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "Password", "UpdatedAt", "Username" },
                values: new object[] { 2, new DateTime(2020, 7, 1, 22, 7, 2, 177, DateTimeKind.Local).AddTicks(8546), null, "user@gmail.com", "User", true, false, "user", "6583122D691EAFAADB3583F0B0F122CA", null, "userUser" });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "ScreeningId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 3, new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(3040), null, true, false, 1, null, 2 },
                    { 4, new DateTime(2020, 7, 1, 22, 7, 2, 179, DateTimeKind.Local).AddTicks(3051), null, true, false, 3, null, 2 }
                });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UseCaseId", "UserId" },
                values: new object[] { new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(906), 6, 2 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UseCaseId", "UserId" },
                values: new object[] { new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(921), 7, 2 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UseCaseId", "UserId" },
                values: new object[] { new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(928), 8, 2 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UseCaseId", "UserId" },
                values: new object[] { new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(935), 9, 2 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UseCaseId", "UserId" },
                values: new object[] { new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(942), 10, 2 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UseCaseId", "UserId" },
                values: new object[] { new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(951), 11, 2 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UseCaseId", "UserId" },
                values: new object[] { new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(959), 12, 2 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UseCaseId", "UserId" },
                values: new object[] { new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(965), 13, 2 });

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UseCaseId", "UserId" },
                values: new object[] { new DateTime(2020, 7, 1, 22, 7, 2, 178, DateTimeKind.Local).AddTicks(972), 3, 2 });
        }
    }
}
