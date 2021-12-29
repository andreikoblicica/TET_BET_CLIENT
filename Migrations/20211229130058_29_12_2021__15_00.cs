using Microsoft.EntityFrameworkCore.Migrations;

namespace TET_BET.Migrations
{
    public partial class _29_12_2021__15_00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "oddValue",
                table: "DBUserBet");

            migrationBuilder.AddColumn<float>(
                name: "oddValue",
                table: "DBBet",
                type: "float",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "oddValue",
                table: "DBBet");

            migrationBuilder.AddColumn<float>(
                name: "oddValue",
                table: "DBUserBet",
                type: "float",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
