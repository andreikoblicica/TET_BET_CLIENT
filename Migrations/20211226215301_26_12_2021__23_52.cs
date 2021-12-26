using Microsoft.EntityFrameworkCore.Migrations;

namespace TET_BET.Migrations
{
    public partial class _26_12_2021__23_52 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DBTransaction_DBAccountDetails_accountDetailsID",
                table: "DBTransaction");

            migrationBuilder.AlterColumn<int>(
                name: "accountDetailsID",
                table: "DBTransaction",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DBTransaction_DBAccountDetails_accountDetailsID",
                table: "DBTransaction",
                column: "accountDetailsID",
                principalTable: "DBAccountDetails",
                principalColumn: "accountDetailsID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DBTransaction_DBAccountDetails_accountDetailsID",
                table: "DBTransaction");

            migrationBuilder.AlterColumn<int>(
                name: "accountDetailsID",
                table: "DBTransaction",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_DBTransaction_DBAccountDetails_accountDetailsID",
                table: "DBTransaction",
                column: "accountDetailsID",
                principalTable: "DBAccountDetails",
                principalColumn: "accountDetailsID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
