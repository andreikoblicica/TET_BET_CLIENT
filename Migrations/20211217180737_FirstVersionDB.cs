using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace TET_BET.Migrations
{
    public partial class FirstVersionDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DBAccountDetails",
                columns: table => new
                {
                    accountDetailsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    dateRegistered = table.Column<DateTime>(type: "datetime", nullable: false),
                    accountBalance = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBAccountDetails", x => x.accountDetailsID);
                });

            migrationBuilder.CreateTable(
                name: "DBBettingEventStatus",
                columns: table => new
                {
                    bettingEventStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    bettingEventStatusMessage = table.Column<string>(type: "text", nullable: true),
                    bettingEventStatusDescription = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBBettingEventStatus", x => x.bettingEventStatusID);
                });

            migrationBuilder.CreateTable(
                name: "DBFootballEvent",
                columns: table => new
                {
                    footballEventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBFootballEvent", x => x.footballEventID);
                });

            migrationBuilder.CreateTable(
                name: "DBSport",
                columns: table => new
                {
                    sportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sportName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBSport", x => x.sportID);
                });

            migrationBuilder.CreateTable(
                name: "DBBettingTicket",
                columns: table => new
                {
                    bettingTicketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    bettingTicketSum = table.Column<float>(type: "float", nullable: false),
                    bettingTicketDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    accountDetailsID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBBettingTicket", x => x.bettingTicketID);
                    table.ForeignKey(
                        name: "FK_DBBettingTicket_DBAccountDetails_accountDetailsID",
                        column: x => x.accountDetailsID,
                        principalTable: "DBAccountDetails",
                        principalColumn: "accountDetailsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DBTransaction",
                columns: table => new
                {
                    transactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    transactionSum = table.Column<float>(type: "float", nullable: false),
                    transactionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    accountDetailsID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBTransaction", x => x.transactionID);
                    table.ForeignKey(
                        name: "FK_DBTransaction_DBAccountDetails_accountDetailsID",
                        column: x => x.accountDetailsID,
                        principalTable: "DBAccountDetails",
                        principalColumn: "accountDetailsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DBUser",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    userEmail = table.Column<string>(type: "text", nullable: true),
                    userPassword = table.Column<string>(type: "text", nullable: true),
                    accountDetailsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBUser", x => x.userID);
                    table.ForeignKey(
                        name: "FK_DBUser_DBAccountDetails_accountDetailsID",
                        column: x => x.accountDetailsID,
                        principalTable: "DBAccountDetails",
                        principalColumn: "accountDetailsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DBBetType",
                columns: table => new
                {
                    betTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sportID = table.Column<int>(type: "int", nullable: true),
                    betTypeName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBBetType", x => x.betTypeID);
                    table.ForeignKey(
                        name: "FK_DBBetType_DBSport_sportID",
                        column: x => x.sportID,
                        principalTable: "DBSport",
                        principalColumn: "sportID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DBEvent",
                columns: table => new
                {
                    eventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sportID = table.Column<int>(type: "int", nullable: false),
                    bettingEventStatusID = table.Column<int>(type: "int", nullable: true),
                    bettingEventLocation = table.Column<string>(type: "text", nullable: true),
                    bettingEventDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBEvent", x => x.eventID);
                    table.ForeignKey(
                        name: "FK_DBEvent_DBBettingEventStatus_bettingEventStatusID",
                        column: x => x.bettingEventStatusID,
                        principalTable: "DBBettingEventStatus",
                        principalColumn: "bettingEventStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DBEvent_DBSport_sportID",
                        column: x => x.sportID,
                        principalTable: "DBSport",
                        principalColumn: "sportID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DBBet",
                columns: table => new
                {
                    betID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    betName = table.Column<string>(type: "text", nullable: true),
                    betTypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBBet", x => x.betID);
                    table.ForeignKey(
                        name: "FK_DBBet_DBBetType_betTypeID",
                        column: x => x.betTypeID,
                        principalTable: "DBBetType",
                        principalColumn: "betTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DBUserBet",
                columns: table => new
                {
                    userBetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    eventID = table.Column<int>(type: "int", nullable: false),
                    dbEventeventID = table.Column<int>(type: "int", nullable: true),
                    betID = table.Column<int>(type: "int", nullable: false),
                    oddValue = table.Column<float>(type: "float", nullable: false),
                    bettingTicketID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBUserBet", x => x.userBetID);
                    table.ForeignKey(
                        name: "FK_DBUserBet_DBBet_betID",
                        column: x => x.betID,
                        principalTable: "DBBet",
                        principalColumn: "betID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DBUserBet_DBBettingTicket_bettingTicketID",
                        column: x => x.bettingTicketID,
                        principalTable: "DBBettingTicket",
                        principalColumn: "bettingTicketID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DBUserBet_DBEvent_dbEventeventID",
                        column: x => x.dbEventeventID,
                        principalTable: "DBEvent",
                        principalColumn: "eventID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DBBet_betTypeID",
                table: "DBBet",
                column: "betTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DBBettingTicket_accountDetailsID",
                table: "DBBettingTicket",
                column: "accountDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_DBBetType_sportID",
                table: "DBBetType",
                column: "sportID");

            migrationBuilder.CreateIndex(
                name: "IX_DBEvent_bettingEventStatusID",
                table: "DBEvent",
                column: "bettingEventStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_DBEvent_sportID",
                table: "DBEvent",
                column: "sportID");

            migrationBuilder.CreateIndex(
                name: "IX_DBTransaction_accountDetailsID",
                table: "DBTransaction",
                column: "accountDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_DBUser_accountDetailsID",
                table: "DBUser",
                column: "accountDetailsID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DBUserBet_betID",
                table: "DBUserBet",
                column: "betID");

            migrationBuilder.CreateIndex(
                name: "IX_DBUserBet_bettingTicketID",
                table: "DBUserBet",
                column: "bettingTicketID");

            migrationBuilder.CreateIndex(
                name: "IX_DBUserBet_dbEventeventID",
                table: "DBUserBet",
                column: "dbEventeventID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DBFootballEvent");

            migrationBuilder.DropTable(
                name: "DBTransaction");

            migrationBuilder.DropTable(
                name: "DBUser");

            migrationBuilder.DropTable(
                name: "DBUserBet");

            migrationBuilder.DropTable(
                name: "DBBet");

            migrationBuilder.DropTable(
                name: "DBBettingTicket");

            migrationBuilder.DropTable(
                name: "DBEvent");

            migrationBuilder.DropTable(
                name: "DBBetType");

            migrationBuilder.DropTable(
                name: "DBAccountDetails");

            migrationBuilder.DropTable(
                name: "DBBettingEventStatus");

            migrationBuilder.DropTable(
                name: "DBSport");
        }
    }
}
