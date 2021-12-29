using Microsoft.EntityFrameworkCore.Migrations;

namespace TET_BET.Migrations
{
    public partial class _28_12_2021__17_37 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "goalsTeam0FirstHalf",
                table: "DBFootballEvent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "goalsTeam0SecondHalf",
                table: "DBFootballEvent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "goalsTeam1FirstHalf",
                table: "DBFootballEvent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "goalsTeam1SecondHalf",
                table: "DBFootballEvent",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "goalsTeam0FirstHalf",
                table: "DBFootballEvent");

            migrationBuilder.DropColumn(
                name: "goalsTeam0SecondHalf",
                table: "DBFootballEvent");

            migrationBuilder.DropColumn(
                name: "goalsTeam1FirstHalf",
                table: "DBFootballEvent");

            migrationBuilder.DropColumn(
                name: "goalsTeam1SecondHalf",
                table: "DBFootballEvent");
        }
    }
}
