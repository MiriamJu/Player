using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "player",
                columns: table => new
                {
                    PlayerId = table.Column<string>(type: "text", nullable: false),
                    BirthYear = table.Column<int>(type: "integer", nullable: false),
                    BirthMonth = table.Column<int>(type: "integer", nullable: false),
                    BirthDay = table.Column<int>(type: "integer", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    DeathYear = table.Column<int>(type: "integer", nullable: false),
                    DeathMonth = table.Column<int>(type: "integer", nullable: false),
                    DeathDay = table.Column<int>(type: "integer", nullable: false),
                    DeathCountry = table.Column<string>(type: "text", nullable: true),
                    DeathState = table.Column<string>(type: "text", nullable: true),
                    DeathCity = table.Column<string>(type: "text", nullable: true),
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "player");
        }
    }
}
