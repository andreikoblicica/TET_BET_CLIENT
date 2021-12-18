using Microsoft.EntityFrameworkCore.Migrations;

namespace TET_BET.Migrations
{
    public partial class _18_12_21__20_55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "footballLeagueID",
                table: "DBFootballEvent",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DBFootballEvent_footballLeagueID",
                table: "DBFootballEvent",
                column: "footballLeagueID");

            migrationBuilder.AddForeignKey(
                name: "FK_DBFootballEvent_DBFootballLeague_footballLeagueID",
                table: "DBFootballEvent",
                column: "footballLeagueID",
                principalTable: "DBFootballLeague",
                principalColumn: "footballLeagueID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DBFootballEvent_DBFootballLeague_footballLeagueID",
                table: "DBFootballEvent");

            migrationBuilder.DropIndex(
                name: "IX_DBFootballEvent_footballLeagueID",
                table: "DBFootballEvent");

            migrationBuilder.DropColumn(
                name: "footballLeagueID",
                table: "DBFootballEvent");
        }
    }
}
