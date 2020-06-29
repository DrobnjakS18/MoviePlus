using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class movieimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeatsReserved");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Movies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(1207), "d72a304f-b6b0-466f-806d-505756825176.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(2813), "6d5dd6aa-477a-4a6d-9e32-1133607881c5.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(2859), "38e87283-fa50-4509-8a34-0b92afda5cc2.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(2863), "6d16d467-e8ac-4990-b5cd-1c3d103e82c0.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(2867), "9b263823-5bf0-41a2-8ff2-a6c6f873c43c.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(2872), "09459e52-bee9-4adc-8724-605b4f95fe62.jpg" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Image" },
                values: new object[] { new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(2875), "fc2645ba-d817-4a60-8150-f3c66777361b.jpg" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 998, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 999, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 995, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 15, 17, 998, DateTimeKind.Local).AddTicks(8985));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "SeatsReserved",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    ScreeningId = table.Column<int>(type: "int", nullable: false),
                    SeatId = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatsReserved", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 44, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 37, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 12, 53, 59, 43, DateTimeKind.Local).AddTicks(3243));
        }
    }
}
