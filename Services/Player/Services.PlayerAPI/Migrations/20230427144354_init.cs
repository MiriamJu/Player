using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.PlayerAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "player",
                columns: table => new
                {
                    PlayerId = table.Column<string>(type: "text", nullable: false),
                    NameFirst = table.Column<string>(type: "text", nullable: true),
                    NameLast = table.Column<string>(type: "text", nullable: true),
                    NameGiven = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    Bats = table.Column<int>(type: "integer", nullable: false),
                    Throws = table.Column<int>(type: "integer", nullable: false),
                    Debut = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FinalGame = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RetroId = table.Column<string>(type: "text", nullable: true),
                    DdRefId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_player", x => x.PlayerId);
                });

            migrationBuilder.CreateTable(
                name: "BirthStatusAdditionalData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    Month = table.Column<int>(type: "integer", nullable: false),
                    Day = table.Column<int>(type: "integer", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    PlayerId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirthStatusAdditionalData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BirthStatusAdditionalData_player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "player",
                        principalColumn: "PlayerId");
                });

            migrationBuilder.CreateTable(
                name: "DeathStatusAdditionalData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    Month = table.Column<int>(type: "integer", nullable: false),
                    Day = table.Column<int>(type: "integer", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    PlayerId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeathStatusAdditionalData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeathStatusAdditionalData_player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "player",
                        principalColumn: "PlayerId");
                });

            migrationBuilder.InsertData(
                table: "player",
                columns: new[] { "PlayerId", "Bats", "DdRefId", "Debut", "FinalGame", "NameFirst", "NameGiven", "NameLast", "RetroId", "Throws", "Weight" },
                values: new object[] { "aa", 1, "123", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "aa", "aa", "aa", "123", 1, 130 });

            migrationBuilder.InsertData(
                table: "BirthStatusAdditionalData",
                columns: new[] { "Id", "City", "Country", "Day", "Month", "PlayerId", "State", "Year", "status" },
                values: new object[] { new Guid("4df64da7-c2cd-4192-b15e-44d27bbfbd41"), "a", "b", 1, 2, "aa", "1", 2000, 0 });

            migrationBuilder.InsertData(
                table: "DeathStatusAdditionalData",
                columns: new[] { "Id", "City", "Country", "Day", "Month", "PlayerId", "State", "Year", "status" },
                values: new object[] { new Guid("2c61bb88-d982-4860-94de-46d8b5c09228"), "a", "b", 1, 2, "aa", "1", 2000, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_BirthStatusAdditionalData_PlayerId",
                table: "BirthStatusAdditionalData",
                column: "PlayerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeathStatusAdditionalData_PlayerId",
                table: "DeathStatusAdditionalData",
                column: "PlayerId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BirthStatusAdditionalData");

            migrationBuilder.DropTable(
                name: "DeathStatusAdditionalData");

            migrationBuilder.DropTable(
                name: "player");
        }
    }
}
