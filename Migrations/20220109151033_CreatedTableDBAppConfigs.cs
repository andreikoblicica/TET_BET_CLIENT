using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace TET_BET.Migrations
{
    public partial class CreatedTableDBAppConfigs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DBFootballEventfootballEventID",
                table: "DBBet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DBAppConfigs",
                columns: table => new
                {
                    appConfigID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    appConfigKey = table.Column<string>(type: "text", nullable: true),
                    appConfigValue = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    isEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBAppConfigs", x => x.appConfigID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DBBet_DBFootballEventfootballEventID",
                table: "DBBet",
                column: "DBFootballEventfootballEventID");

            migrationBuilder.AddForeignKey(
                name: "FK_DBBet_DBFootballEvent_DBFootballEventfootballEventID",
                table: "DBBet",
                column: "DBFootballEventfootballEventID",
                principalTable: "DBFootballEvent",
                principalColumn: "footballEventID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DBBet_DBFootballEvent_DBFootballEventfootballEventID",
                table: "DBBet");

            migrationBuilder.DropTable(
                name: "DBAppConfigs");

            migrationBuilder.DropIndex(
                name: "IX_DBBet_DBFootballEventfootballEventID",
                table: "DBBet");

            migrationBuilder.DropColumn(
                name: "DBFootballEventfootballEventID",
                table: "DBBet");
        }
    }
}
