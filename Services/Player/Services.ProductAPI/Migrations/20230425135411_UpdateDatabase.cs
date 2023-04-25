using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "player");

            migrationBuilder.DropColumn(
                name: "BirthMonth",
                table: "player");

            migrationBuilder.DropColumn(
                name: "BirthYear",
                table: "player");

            migrationBuilder.DropColumn(
                name: "BirthCity",
                table: "player");

            migrationBuilder.DropColumn(
                name: "BirthCountry",
                table: "player");

            migrationBuilder.DropColumn(
                name: "DeathCity",
                table: "player");

            migrationBuilder.DropColumn(
                name: "DeathCountry",
                table: "player");

            migrationBuilder.DropColumn(
                name: "DeathDay",
                table: "player");

            migrationBuilder.DropColumn(
                name: "DeathMonth",
                table: "player");

            migrationBuilder.DropColumn(
                name: "DeathState",
                table: "player");

            migrationBuilder.DropColumn(
                name: "DeathYear",
                table: "player");

            migrationBuilder.DropColumn(
                name: "BirthState",
                table: "player");

            migrationBuilder.AddColumn<Guid>(
                name: "BirthStatusAdditionalDataId",
                table: "player",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeathStatusAdditionalDataId",
                table: "player",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LifeStatusAdditionalData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    Month = table.Column<int>(type: "integer", nullable: false),
                    Day = table.Column<int>(type: "integer", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifeStatusAdditionalData", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_player_BirthStatusAdditionalDataId",
                table: "player",
                column: "BirthStatusAdditionalDataId");

            migrationBuilder.CreateIndex(
                name: "IX_player_DeathStatusAdditionalDataId",
                table: "player",
                column: "DeathStatusAdditionalDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_player_LifeStatusAdditionalData_BirthStatusAdditionalDataId",
                table: "player",
                column: "BirthStatusAdditionalDataId",
                principalTable: "LifeStatusAdditionalData",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_player_LifeStatusAdditionalData_DeathStatusAdditionalDataId",
                table: "player",
                column: "DeathStatusAdditionalDataId",
                principalTable: "LifeStatusAdditionalData",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_player_LifeStatusAdditionalData_BirthStatusAdditionalDataId",
                table: "player");

            migrationBuilder.DropForeignKey(
                name: "FK_player_LifeStatusAdditionalData_DeathStatusAdditionalDataId",
                table: "player");

            migrationBuilder.DropTable(
                name: "LifeStatusAdditionalData");

            migrationBuilder.DropIndex(
                name: "IX_player_BirthStatusAdditionalDataId",
                table: "player");

            migrationBuilder.DropIndex(
                name: "IX_player_DeathStatusAdditionalDataId",
                table: "player");

            migrationBuilder.DropColumn(
                name: "BirthStatusAdditionalDataId",
                table: "player");

            migrationBuilder.DropColumn(
                name: "DeathStatusAdditionalDataId",
                table: "player");

            migrationBuilder.AddColumn<int>(
                name: "BirthDay",
                table: "player",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BirthMonth",
                table: "player",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BirthYear",
                table: "player",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BirthCity",
                table: "player",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthCountry",
                table: "player",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeathCity",
                table: "player",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeathCountry",
                table: "player",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeathDay",
                table: "player",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeathMonth",
                table: "player",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DeathState",
                table: "player",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeathYear",
                table: "player",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BirthState",
                table: "player",
                type: "text",
                nullable: true);
        }
    }
}
