using Microsoft.EntityFrameworkCore.Migrations;

namespace TET_BET.Migrations
{
    public partial class _28_12_2021__15_32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "rapidAPIFixtureID",
                table: "DBFootballEvent",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rapidAPIFixtureID",
                table: "DBFootballEvent");
        }
    }
}
