using Microsoft.EntityFrameworkCore.Migrations;

namespace TET_BET.Migrations
{
    public partial class _28_12_2021__18_11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "rapidAPIBetID",
                table: "DBBetType",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rapidAPIBetID",
                table: "DBBetType");
        }
    }
}
