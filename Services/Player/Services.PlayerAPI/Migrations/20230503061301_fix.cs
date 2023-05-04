using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.PlayerAPI.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BirthStatusAdditionalData",
                keyColumn: "Id",
                keyValue: new Guid("97d67399-70ac-429b-8ee3-3951d411e372"));

            migrationBuilder.DeleteData(
                table: "DeathStatusAdditionalData",
                keyColumn: "Id",
                keyValue: new Guid("73f062bf-89e7-452c-8eb5-c708ee4d460b"));

            migrationBuilder.AlterColumn<string>(
                name: "Bats",
                table: "player",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "player",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "BirthStatusAdditionalData",
                columns: new[] { "Id", "City", "Country", "Day", "Month", "PlayerId", "State", "Year", "status" },
                values: new object[] { new Guid("bbf77428-bf59-48e8-8120-6a89ad4c4c58"), "a", "b", 1, 2, "aa", "1", 2000, 0 });

            migrationBuilder.InsertData(
                table: "DeathStatusAdditionalData",
                columns: new[] { "Id", "City", "Country", "Day", "Month", "PlayerId", "State", "Year", "status" },
                values: new object[] { new Guid("a00cee4d-ca89-4463-8d3f-e21fdbbdfeb3"), "a", "b", 1, 2, "aa", "1", 2000, 0 });

            migrationBuilder.UpdateData(
                table: "player",
                keyColumn: "PlayerId",
                keyValue: "aa",
                columns: new[] { "Bats", "Height" },
                values: new object[] { "R", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BirthStatusAdditionalData",
                keyColumn: "Id",
                keyValue: new Guid("bbf77428-bf59-48e8-8120-6a89ad4c4c58"));

            migrationBuilder.DeleteData(
                table: "DeathStatusAdditionalData",
                keyColumn: "Id",
                keyValue: new Guid("a00cee4d-ca89-4463-8d3f-e21fdbbdfeb3"));

            migrationBuilder.DropColumn(
                name: "Height",
                table: "player");

            migrationBuilder.AlterColumn<int>(
                name: "Bats",
                table: "player",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "BirthStatusAdditionalData",
                columns: new[] { "Id", "City", "Country", "Day", "Month", "PlayerId", "State", "Year", "status" },
                values: new object[] { new Guid("97d67399-70ac-429b-8ee3-3951d411e372"), "a", "b", 1, 2, "aa", "1", 2000, 0 });

            migrationBuilder.InsertData(
                table: "DeathStatusAdditionalData",
                columns: new[] { "Id", "City", "Country", "Day", "Month", "PlayerId", "State", "Year", "status" },
                values: new object[] { new Guid("73f062bf-89e7-452c-8eb5-c708ee4d460b"), "a", "b", 1, 2, "aa", "1", 2000, 0 });

            migrationBuilder.UpdateData(
                table: "player",
                keyColumn: "PlayerId",
                keyValue: "aa",
                column: "Bats",
                value: 1);
        }
    }
}
