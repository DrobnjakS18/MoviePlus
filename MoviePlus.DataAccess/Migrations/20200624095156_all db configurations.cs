using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class alldbconfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auditoriums_Screenings_ScreeningId",
                table: "Auditoriums");

            migrationBuilder.DropForeignKey(
                name: "FK_Auditoriums_Seats_SeatId",
                table: "Auditoriums");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Screenings_ScreeningId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_SeatsReserved_SeatReservedId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_SeatsReserved_SeatReservedId",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Seats_SeatsReserved_SeatReservedId",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Reservations_ReservationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ReservationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Seats_SeatReservedId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Screenings_SeatReservedId",
                table: "Screenings");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_SeatReservedId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ScreeningId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Auditoriums_ScreeningId",
                table: "Auditoriums");

            migrationBuilder.DropIndex(
                name: "IX_Auditoriums_SeatId",
                table: "Auditoriums");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SeatReservedId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "SeatReservedId",
                table: "Screenings");

            migrationBuilder.DropColumn(
                name: "SeatReservedId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ScreeningId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ScreeningId",
                table: "Auditoriums");

            migrationBuilder.DropColumn(
                name: "SeatId",
                table: "Auditoriums");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movies",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movies",
                maxLength: 1500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Auditoriums",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "Name", "SeatNumbers", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 24, 11, 51, 56, 252, DateTimeKind.Local).AddTicks(2147), null, true, false, "Auditorium 1", 20, null },
                    { 2, new DateTime(2020, 6, 24, 11, 51, 56, 252, DateTimeKind.Local).AddTicks(2982), null, true, false, "Auditorium 2", 30, null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Duration", "IsActive", "IsDeleted", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 24, 11, 51, 56, 251, DateTimeKind.Local).AddTicks(8402), null, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", 142, true, false, "The Shawshank Redemption ", null },
                    { 2, new DateTime(2020, 6, 24, 11, 51, 56, 251, DateTimeKind.Local).AddTicks(9676), null, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", 175, true, false, "The Godfather", null },
                    { 3, new DateTime(2020, 6, 24, 11, 51, 56, 251, DateTimeKind.Local).AddTicks(9720), null, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", 152, true, false, "The Dark Knight", null },
                    { 4, new DateTime(2020, 6, 24, 11, 51, 56, 251, DateTimeKind.Local).AddTicks(9724), null, "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", 96, true, false, "12 Angry Men", null },
                    { 5, new DateTime(2020, 6, 24, 11, 51, 56, 251, DateTimeKind.Local).AddTicks(9728), null, "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", 195, true, false, "Schindler's List", null },
                    { 6, new DateTime(2020, 6, 24, 11, 51, 56, 251, DateTimeKind.Local).AddTicks(9734), null, "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", 201, true, false, "The Lord of the Rings: The Return of the King", null },
                    { 7, new DateTime(2020, 6, 24, 11, 51, 56, 251, DateTimeKind.Local).AddTicks(9737), null, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", 154, true, false, "Pulp Fiction", null }
                });

            migrationBuilder.InsertData(
                table: "UserUseCases",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "UpdatedAt", "UseCaseId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 24, 11, 51, 56, 251, DateTimeKind.Local).AddTicks(6472), null, true, false, null, 1, 2 },
                    { 2, new DateTime(2020, 6, 24, 11, 51, 56, 251, DateTimeKind.Local).AddTicks(7760), null, true, false, null, 2, 2 },
                    { 3, new DateTime(2020, 6, 24, 11, 51, 56, 251, DateTimeKind.Local).AddTicks(7794), null, true, false, null, 3, 2 },
                    { 4, new DateTime(2020, 6, 24, 11, 51, 56, 251, DateTimeKind.Local).AddTicks(7798), null, true, false, null, 4, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 24, 11, 51, 56, 247, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 24, 11, 51, 56, 251, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "AuditoriumId", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "MovieId", "ScreeningTime", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 6, 24, 11, 51, 56, 252, DateTimeKind.Local).AddTicks(246), null, true, false, 1, new DateTime(2020, 7, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 2, new DateTime(2020, 6, 24, 11, 51, 56, 252, DateTimeKind.Local).AddTicks(1590), null, true, false, 3, new DateTime(2020, 7, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 2, new DateTime(2020, 6, 24, 11, 51, 56, 252, DateTimeKind.Local).AddTicks(1623), null, true, false, 5, new DateTime(2020, 7, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "AuditoriumId", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "Number", "Row", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 6, 24, 11, 51, 56, 252, DateTimeKind.Local).AddTicks(3495), null, true, false, 1, 1, null },
                    { 2, 1, new DateTime(2020, 6, 24, 11, 51, 56, 252, DateTimeKind.Local).AddTicks(4732), null, true, false, 2, 1, null },
                    { 3, 2, new DateTime(2020, 6, 24, 11, 51, 56, 252, DateTimeKind.Local).AddTicks(4770), null, true, false, 1, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "ScreeningId", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2020, 6, 24, 11, 51, 56, 252, DateTimeKind.Local).AddTicks(7097), null, true, false, 1, null, 1 });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "ScreeningId", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2020, 6, 24, 11, 51, 56, 252, DateTimeKind.Local).AddTicks(7888), null, true, false, 1, null, 2 });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "ScreeningId", "UpdatedAt", "UserId" },
                values: new object[] { 3, new DateTime(2020, 6, 24, 11, 51, 56, 252, DateTimeKind.Local).AddTicks(7914), null, true, false, 2, null, 2 });

            migrationBuilder.InsertData(
                table: "SeatsReserved",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "ReservationId", "ScreeningId", "SeatId", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2020, 6, 24, 11, 51, 56, 252, DateTimeKind.Local).AddTicks(5248), null, true, false, 1, 1, 1, null });

            migrationBuilder.InsertData(
                table: "SeatsReserved",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "ReservationId", "ScreeningId", "SeatId", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2020, 6, 24, 11, 51, 56, 252, DateTimeKind.Local).AddTicks(6413), null, true, false, 2, 1, 2, null });

            migrationBuilder.InsertData(
                table: "SeatsReserved",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "ReservationId", "ScreeningId", "SeatId", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2020, 6, 24, 11, 51, 56, 252, DateTimeKind.Local).AddTicks(6448), null, true, false, 2, 1, 3, null });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeatsReserved_ReservationId",
                table: "SeatsReserved",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatsReserved_ScreeningId",
                table: "SeatsReserved",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatsReserved_SeatId",
                table: "SeatsReserved",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_AuditoriumId",
                table: "Seats",
                column: "AuditoriumId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_AuditoriumId",
                table: "Screenings",
                column: "AuditoriumId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MovieId",
                table: "Screenings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Description",
                table: "Movies",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Title",
                table: "Movies",
                column: "Title",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Auditoriums_AuditoriumId",
                table: "Screenings",
                column: "AuditoriumId",
                principalTable: "Auditoriums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Movies_MovieId",
                table: "Screenings",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Auditoriums_AuditoriumId",
                table: "Seats",
                column: "AuditoriumId",
                principalTable: "Auditoriums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatsReserved_Reservations_ReservationId",
                table: "SeatsReserved",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatsReserved_Screenings_ScreeningId",
                table: "SeatsReserved",
                column: "ScreeningId",
                principalTable: "Screenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatsReserved_Seats_SeatId",
                table: "SeatsReserved",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_UserId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Auditoriums_AuditoriumId",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Movies_MovieId",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Auditoriums_AuditoriumId",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatsReserved_Reservations_ReservationId",
                table: "SeatsReserved");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatsReserved_Screenings_ScreeningId",
                table: "SeatsReserved");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatsReserved_Seats_SeatId",
                table: "SeatsReserved");

            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_SeatsReserved_ReservationId",
                table: "SeatsReserved");

            migrationBuilder.DropIndex(
                name: "IX_SeatsReserved_ScreeningId",
                table: "SeatsReserved");

            migrationBuilder.DropIndex(
                name: "IX_SeatsReserved_SeatId",
                table: "SeatsReserved");

            migrationBuilder.DropIndex(
                name: "IX_Seats_AuditoriumId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Screenings_AuditoriumId",
                table: "Screenings");

            migrationBuilder.DropIndex(
                name: "IX_Screenings_MovieId",
                table: "Screenings");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Movies_Description",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_Title",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SeatsReserved",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserUseCases",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Screenings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Auditoriums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeatReservedId",
                table: "Seats",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeatReservedId",
                table: "Screenings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeatReservedId",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1500);

            migrationBuilder.AddColumn<int>(
                name: "ScreeningId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScreeningId",
                table: "Auditoriums",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeatId",
                table: "Auditoriums",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 23, 16, 42, 58, 680, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 23, 16, 42, 58, 684, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.CreateIndex(
                name: "IX_Users_ReservationId",
                table: "Users",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_SeatReservedId",
                table: "Seats",
                column: "SeatReservedId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_SeatReservedId",
                table: "Screenings",
                column: "SeatReservedId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SeatReservedId",
                table: "Reservations",
                column: "SeatReservedId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ScreeningId",
                table: "Movies",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_Auditoriums_ScreeningId",
                table: "Auditoriums",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_Auditoriums_SeatId",
                table: "Auditoriums",
                column: "SeatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Auditoriums_Screenings_ScreeningId",
                table: "Auditoriums",
                column: "ScreeningId",
                principalTable: "Screenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Auditoriums_Seats_SeatId",
                table: "Auditoriums",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Screenings_ScreeningId",
                table: "Movies",
                column: "ScreeningId",
                principalTable: "Screenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_SeatsReserved_SeatReservedId",
                table: "Reservations",
                column: "SeatReservedId",
                principalTable: "SeatsReserved",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_SeatsReserved_SeatReservedId",
                table: "Screenings",
                column: "SeatReservedId",
                principalTable: "SeatsReserved",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_SeatsReserved_SeatReservedId",
                table: "Seats",
                column: "SeatReservedId",
                principalTable: "SeatsReserved",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Reservations_ReservationId",
                table: "Users",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
