using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class userconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "Password", "ReservationId", "UpdatedAt", "Username" },
                values: new object[] { 1, new DateTime(2020, 6, 23, 16, 41, 32, 149, DateTimeKind.Local).AddTicks(4452), null, "admin@gmail.com", "Admin", false, false, "Admin", "pass123", null, null, "adminAdmin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "Password", "ReservationId", "UpdatedAt", "Username" },
                values: new object[] { 2, new DateTime(2020, 6, 23, 16, 41, 32, 153, DateTimeKind.Local).AddTicks(5560), null, "user@gmail.com", "User", false, false, "user", "pass123", null, null, "userUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Email",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
