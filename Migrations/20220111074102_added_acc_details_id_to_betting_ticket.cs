using Microsoft.EntityFrameworkCore.Migrations;

namespace TET_BET.Migrations
{
    public partial class added_acc_details_id_to_betting_ticket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DBBettingTicket_DBAccountDetails_accountDetailsID",
                table: "DBBettingTicket");

            migrationBuilder.AlterColumn<int>(
                name: "accountDetailsID",
                table: "DBBettingTicket",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DBBettingTicket_DBAccountDetails_accountDetailsID",
                table: "DBBettingTicket",
                column: "accountDetailsID",
                principalTable: "DBAccountDetails",
                principalColumn: "accountDetailsID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DBBettingTicket_DBAccountDetails_accountDetailsID",
                table: "DBBettingTicket");

            migrationBuilder.AlterColumn<int>(
                name: "accountDetailsID",
                table: "DBBettingTicket",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_DBBettingTicket_DBAccountDetails_accountDetailsID",
                table: "DBBettingTicket",
                column: "accountDetailsID",
                principalTable: "DBAccountDetails",
                principalColumn: "accountDetailsID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
