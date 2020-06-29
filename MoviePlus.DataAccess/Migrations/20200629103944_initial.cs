using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePlus.DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditLogger",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UseCaseName = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    Actor = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Auditoriums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditoriums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 1500, nullable: false),
                    Duration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeatsReserved",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    SeatId = table.Column<int>(nullable: false),
                    ReservationId = table.Column<int>(nullable: false),
                    ScreeningId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatsReserved", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 32, nullable: false),
                    LastName = table.Column<string>(maxLength: 32, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Username = table.Column<string>(maxLength: 32, nullable: false),
                    Password = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    AuditoriumId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seats_Auditoriums_AuditoriumId",
                        column: x => x.AuditoriumId,
                        principalTable: "Auditoriums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    AuditoriumId = table.Column<int>(nullable: false),
                    ScreeningTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screenings_Auditoriums_AuditoriumId",
                        column: x => x.AuditoriumId,
                        principalTable: "Auditoriums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Screenings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserUseCases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UseCaseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserUseCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserUseCases_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ScreeningId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Screenings_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "Screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Auditoriums",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(2353), null, true, false, "Auditorium 1", null },
                    { 2, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(2807), null, true, false, "Auditorium 2", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Duration", "IsActive", "IsDeleted", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8736), null, "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", 142, true, false, "The Shawshank Redemption ", null },
                    { 2, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(9959), null, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", 175, true, false, "The Godfather", null },
                    { 3, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(9996), null, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", 152, true, false, "The Dark Knight", null },
                    { 4, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local), null, "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.", 96, true, false, "12 Angry Men", null },
                    { 5, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(3), null, "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", 195, true, false, "Schindler's List", null },
                    { 6, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(8), null, "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", 201, true, false, "The Lord of the Rings: The Return of the King", null },
                    { 7, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(11), null, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", 154, true, false, "Pulp Fiction", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "Password", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 29, 12, 39, 44, 398, DateTimeKind.Local).AddTicks(1164), null, "admin@gmail.com", "Admin", true, false, "Admin", "A12450CFF6FB7A97C975BFB7FCBB8F7E", null, "adminAdmin" },
                    { 2, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(6548), null, "user@gmail.com", "User", true, false, "user", "6583122D691EAFAADB3583F0B0F122CA", null, "userUser" }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "AuditoriumId", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "MovieId", "ScreeningTime", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(510), null, true, false, 1, new DateTime(2020, 7, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 2, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(1817), null, true, false, 1, new DateTime(2020, 7, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 2, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(1849), null, true, false, 2, new DateTime(2020, 7, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 2, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(1852), null, true, false, 3, new DateTime(2020, 7, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "AuditoriumId", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "Number", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(3301), null, true, false, 1, null },
                    { 2, 1, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(4108), null, true, false, 2, null },
                    { 3, 2, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(4132), null, true, false, 1, null }
                });

            migrationBuilder.InsertData(
                table: "UserUseCases",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "UpdatedAt", "UseCaseId", "UserId" },
                values: new object[,]
                {
                    { 11, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8199), null, true, false, null, 12, 2 },
                    { 10, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8195), null, true, false, null, 11, 2 },
                    { 9, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8191), null, true, false, null, 10, 2 },
                    { 8, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8188), null, true, false, null, 9, 2 },
                    { 7, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8185), null, true, false, null, 8, 2 },
                    { 6, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8182), null, true, false, null, 7, 2 },
                    { 4, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8174), null, true, false, null, 4, 1 },
                    { 14, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8208), null, true, false, null, 5, 1 },
                    { 12, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8202), null, true, false, null, 13, 2 },
                    { 3, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8170), null, true, false, null, 3, 1 },
                    { 2, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8144), null, true, false, null, 2, 1 },
                    { 1, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(7251), null, true, false, null, 1, 1 },
                    { 5, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8177), null, true, false, null, 6, 2 },
                    { 13, new DateTime(2020, 6, 29, 12, 39, 44, 401, DateTimeKind.Local).AddTicks(8205), null, true, false, null, 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "ScreeningId", "UpdatedAt", "UserId" },
                values: new object[] { 1, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(4614), null, true, false, 1, null, 1 });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsActive", "IsDeleted", "ScreeningId", "UpdatedAt", "UserId" },
                values: new object[] { 2, new DateTime(2020, 6, 29, 12, 39, 44, 402, DateTimeKind.Local).AddTicks(5407), null, true, false, 2, null, 2 });

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

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ScreeningId",
                table: "Reservations",
                column: "ScreeningId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MovieId",
                table: "Screenings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_AuditoriumId_ScreeningTime",
                table: "Screenings",
                columns: new[] { "AuditoriumId", "ScreeningTime" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seats_AuditoriumId",
                table: "Seats",
                column: "AuditoriumId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserUseCases_UserId",
                table: "UserUseCases",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogger");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "SeatsReserved");

            migrationBuilder.DropTable(
                name: "UserUseCases");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Auditoriums");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
