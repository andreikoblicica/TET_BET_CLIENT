using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace TET_BET.Migrations
{
    public partial class _18_12_21__20_50 : Migration
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
                name: "DBCountry",
                columns: table => new
                {
                    countryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    countryName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBCountry", x => x.countryID);
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
                    bettingEventStatusID = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DBEvent_DBSport_sportID",
                        column: x => x.sportID,
                        principalTable: "DBSport",
                        principalColumn: "sportID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DBFootballLeague",
                columns: table => new
                {
                    footballLeagueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    season = table.Column<int>(type: "int", nullable: false),
                    leagueName = table.Column<string>(type: "text", nullable: true),
                    sportID = table.Column<int>(type: "int", nullable: false),
                    countryID = table.Column<int>(type: "int", nullable: false),
                    nrTeams = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBFootballLeague", x => x.footballLeagueID);
                    table.ForeignKey(
                        name: "FK_DBFootballLeague_DBCountry_countryID",
                        column: x => x.countryID,
                        principalTable: "DBCountry",
                        principalColumn: "countryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DBFootballLeague_DBSport_sportID",
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
                name: "DBFootballTeam",
                columns: table => new
                {
                    footballTeamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    footballTeamName = table.Column<string>(type: "text", nullable: true),
                    footballTeamStadiumName = table.Column<string>(type: "text", nullable: true),
                    footballTeamManagerName = table.Column<string>(type: "text", nullable: true),
                    footballLeagueID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBFootballTeam", x => x.footballTeamID);
                    table.ForeignKey(
                        name: "FK_DBFootballTeam_DBFootballLeague_footballLeagueID",
                        column: x => x.footballLeagueID,
                        principalTable: "DBFootballLeague",
                        principalColumn: "footballLeagueID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DBFootballEvent",
                columns: table => new
                {
                    footballEventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    footballTeam0footballTeamID = table.Column<int>(type: "int", nullable: true),
                    footballTeam1footballTeamID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBFootballEvent", x => x.footballEventID);
                    table.ForeignKey(
                        name: "FK_DBFootballEvent_DBFootballTeam_footballTeam0footballTeamID",
                        column: x => x.footballTeam0footballTeamID,
                        principalTable: "DBFootballTeam",
                        principalColumn: "footballTeamID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DBFootballEvent_DBFootballTeam_footballTeam1footballTeamID",
                        column: x => x.footballTeam1footballTeamID,
                        principalTable: "DBFootballTeam",
                        principalColumn: "footballTeamID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DBFootballPlayer",
                columns: table => new
                {
                    footballPlayerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    footballPlayerName = table.Column<string>(type: "text", nullable: true),
                    countryID = table.Column<int>(type: "int", nullable: false),
                    footballTeamID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBFootballPlayer", x => x.footballPlayerID);
                    table.ForeignKey(
                        name: "FK_DBFootballPlayer_DBCountry_countryID",
                        column: x => x.countryID,
                        principalTable: "DBCountry",
                        principalColumn: "countryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DBFootballPlayer_DBFootballTeam_footballTeamID",
                        column: x => x.footballTeamID,
                        principalTable: "DBFootballTeam",
                        principalColumn: "footballTeamID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DBEventLookUpTable",
                columns: table => new
                {
                    eventLookUpID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    footballEventID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBEventLookUpTable", x => x.eventLookUpID);
                    table.ForeignKey(
                        name: "FK_DBEventLookUpTable_DBFootballEvent_footballEventID",
                        column: x => x.footballEventID,
                        principalTable: "DBFootballEvent",
                        principalColumn: "footballEventID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DBUserBet",
                columns: table => new
                {
                    userBetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    eventLookUpID = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_DBUserBet_DBEventLookUpTable_eventLookUpID",
                        column: x => x.eventLookUpID,
                        principalTable: "DBEventLookUpTable",
                        principalColumn: "eventLookUpID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_DBEventLookUpTable_footballEventID",
                table: "DBEventLookUpTable",
                column: "footballEventID");

            migrationBuilder.CreateIndex(
                name: "IX_DBFootballEvent_footballTeam0footballTeamID",
                table: "DBFootballEvent",
                column: "footballTeam0footballTeamID");

            migrationBuilder.CreateIndex(
                name: "IX_DBFootballEvent_footballTeam1footballTeamID",
                table: "DBFootballEvent",
                column: "footballTeam1footballTeamID");

            migrationBuilder.CreateIndex(
                name: "IX_DBFootballLeague_countryID",
                table: "DBFootballLeague",
                column: "countryID");

            migrationBuilder.CreateIndex(
                name: "IX_DBFootballLeague_sportID",
                table: "DBFootballLeague",
                column: "sportID");

            migrationBuilder.CreateIndex(
                name: "IX_DBFootballPlayer_countryID",
                table: "DBFootballPlayer",
                column: "countryID");

            migrationBuilder.CreateIndex(
                name: "IX_DBFootballPlayer_footballTeamID",
                table: "DBFootballPlayer",
                column: "footballTeamID");

            migrationBuilder.CreateIndex(
                name: "IX_DBFootballTeam_footballLeagueID",
                table: "DBFootballTeam",
                column: "footballLeagueID");

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

            migrationBuilder.CreateIndex(
                name: "IX_DBUserBet_eventLookUpID",
                table: "DBUserBet",
                column: "eventLookUpID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DBFootballPlayer");

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
                name: "DBEventLookUpTable");

            migrationBuilder.DropTable(
                name: "DBBetType");

            migrationBuilder.DropTable(
                name: "DBAccountDetails");

            migrationBuilder.DropTable(
                name: "DBBettingEventStatus");

            migrationBuilder.DropTable(
                name: "DBFootballEvent");

            migrationBuilder.DropTable(
                name: "DBFootballTeam");

            migrationBuilder.DropTable(
                name: "DBFootballLeague");

            migrationBuilder.DropTable(
                name: "DBCountry");

            migrationBuilder.DropTable(
                name: "DBSport");
        }
    }
}
