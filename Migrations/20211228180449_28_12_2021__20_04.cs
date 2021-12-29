using Microsoft.EntityFrameworkCore.Migrations;

namespace TET_BET.Migrations
{
    public partial class _28_12_2021__20_04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isWinner",
                table: "DBUserBet",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isWinner",
                table: "DBBettingTicket",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isWinner",
                table: "DBUserBet");

            migrationBuilder.DropColumn(
                name: "isWinner",
                table: "DBBettingTicket");
        }
    }
}
