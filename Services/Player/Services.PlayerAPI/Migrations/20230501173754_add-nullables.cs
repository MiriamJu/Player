using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.PlayerAPI.Migrations
{
    /// <inheritdoc />
    public partial class addnullables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BirthStatusAdditionalData",
                keyColumn: "Id",
                keyValue: new Guid("4df64da7-c2cd-4192-b15e-44d27bbfbd41"));

            migrationBuilder.DeleteData(
                table: "DeathStatusAdditionalData",
                keyColumn: "Id",
                keyValue: new Guid("2c61bb88-d982-4860-94de-46d8b5c09228"));

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "player",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "Throws",
                table: "player",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FinalGame",
                table: "player",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Debut",
                table: "player",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "Bats",
                table: "player",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "BirthStatusAdditionalData",
                columns: new[] { "Id", "City", "Country", "Day", "Month", "PlayerId", "State", "Year", "status" },
                values: new object[] { new Guid("97d67399-70ac-429b-8ee3-3951d411e372"), "a", "b", 1, 2, "aa", "1", 2000, 0 });

            migrationBuilder.InsertData(
                table: "DeathStatusAdditionalData",
                columns: new[] { "Id", "City", "Country", "Day", "Month", "PlayerId", "State", "Year", "status" },
                values: new object[] { new Guid("73f062bf-89e7-452c-8eb5-c708ee4d460b"), "a", "b", 1, 2, "aa", "1", 2000, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BirthStatusAdditionalData",
                keyColumn: "Id",
                keyValue: new Guid("97d67399-70ac-429b-8ee3-3951d411e372"));

            migrationBuilder.DeleteData(
                table: "DeathStatusAdditionalData",
                keyColumn: "Id",
                keyValue: new Guid("73f062bf-89e7-452c-8eb5-c708ee4d460b"));

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "player",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Throws",
                table: "player",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FinalGame",
                table: "player",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Debut",
                table: "player",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Bats",
                table: "player",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "BirthStatusAdditionalData",
                columns: new[] { "Id", "City", "Country", "Day", "Month", "PlayerId", "State", "Year", "status" },
                values: new object[] { new Guid("4df64da7-c2cd-4192-b15e-44d27bbfbd41"), "a", "b", 1, 2, "aa", "1", 2000, 0 });

            migrationBuilder.InsertData(
                table: "DeathStatusAdditionalData",
                columns: new[] { "Id", "City", "Country", "Day", "Month", "PlayerId", "State", "Year", "status" },
                values: new object[] { new Guid("2c61bb88-d982-4860-94de-46d8b5c09228"), "a", "b", 1, 2, "aa", "1", 2000, 0 });
        }
    }
}
