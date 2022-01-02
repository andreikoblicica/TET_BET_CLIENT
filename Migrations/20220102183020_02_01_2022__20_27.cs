using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace TET_BET.Migrations
{
    public partial class _02_01_2022__20_27 : Migration
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
                    countryName = table.Column<string>(type: "text", nullable: true),
                    rapidAPICode = table.Column<string>(type: "text", nullable: true)
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
                    accountDetailsID = table.Column<int>(type: "int", nullable: true),
                    isWinner = table.Column<bool>(type: "tinyint(1)", nullable: false)
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
                    accountDetailsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBTransaction", x => x.transactionID);
                    table.ForeignKey(
                        name: "FK_DBTransaction_DBAccountDetails_accountDetailsID",
                        column: x => x.accountDetailsID,
                        principalTable: "DBAccountDetails",
                        principalColumn: "accountDetailsID",
                        onDelete: ReferentialAction.Cascade);
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
                    betTypeName = table.Column<string>(type: "text", nullable: true),
                    rapidAPIBetID = table.Column<int>(type: "int", nullable: false)
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
                name: "DBEventt",
                columns: table => new
                {
                    eventtID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sportID = table.Column<int>(type: "int", nullable: false),
                    bettingEventStatusID = table.Column<int>(type: "int", nullable: false),
                    bettingEventLocation = table.Column<string>(type: "text", nullable: true),
                    bettingEventDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBEventt", x => x.eventtID);
                    table.ForeignKey(
                        name: "FK_DBEventt_DBBettingEventStatus_bettingEventStatusID",
                        column: x => x.bettingEventStatusID,
                        principalTable: "DBBettingEventStatus",
                        principalColumn: "bettingEventStatusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DBEventt_DBSport_sportID",
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
                    nrTeams = table.Column<int>(type: "int", nullable: false),
                    rapidAPIID = table.Column<int>(type: "int", nullable: false)
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
                    rapidAPIID = table.Column<int>(type: "int", nullable: false),
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
                    eventtID = table.Column<int>(type: "int", nullable: false),
                    footballTeam0ID = table.Column<int>(type: "int", nullable: false),
                    footballTeam1ID = table.Column<int>(type: "int", nullable: false),
                    footballLeagueID = table.Column<int>(type: "int", nullable: true),
                    rapidAPIFixtureID = table.Column<int>(type: "int", nullable: false),
                    goalsTeam0FirstHalf = table.Column<int>(type: "int", nullable: false),
                    goalsTeam1FirstHalf = table.Column<int>(type: "int", nullable: false),
                    goalsTeam0SecondHalf = table.Column<int>(type: "int", nullable: false),
                    goalsTeam1SecondHalf = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBFootballEvent", x => x.footballEventID);
                    table.ForeignKey(
                        name: "FK_DBFootballEvent_DBEventt_eventtID",
                        column: x => x.eventtID,
                        principalTable: "DBEventt",
                        principalColumn: "eventtID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DBFootballEvent_DBFootballLeague_footballLeagueID",
                        column: x => x.footballLeagueID,
                        principalTable: "DBFootballLeague",
                        principalColumn: "footballLeagueID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DBFootballEvent_DBFootballTeam_footballTeam0ID",
                        column: x => x.footballTeam0ID,
                        principalTable: "DBFootballTeam",
                        principalColumn: "footballTeamID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DBFootballEvent_DBFootballTeam_footballTeam1ID",
                        column: x => x.footballTeam1ID,
                        principalTable: "DBFootballTeam",
                        principalColumn: "footballTeamID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "DBFootballEventBet",
                columns: table => new
                {
                    footballEventBetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    footballEventID = table.Column<int>(type: "int", nullable: false),
                    betID = table.Column<int>(type: "int", nullable: false),
                    oddValue = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBFootballEventBet", x => x.footballEventBetID);
                    table.ForeignKey(
                        name: "FK_DBFootballEventBet_DBBet_betID",
                        column: x => x.betID,
                        principalTable: "DBBet",
                        principalColumn: "betID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DBFootballEventBet_DBFootballEvent_footballEventID",
                        column: x => x.footballEventID,
                        principalTable: "DBFootballEvent",
                        principalColumn: "footballEventID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DBUserBet",
                columns: table => new
                {
                    userBetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    footballEventBetID = table.Column<int>(type: "int", nullable: false),
                    bettingTicketID = table.Column<int>(type: "int", nullable: false),
                    isWinner = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBUserBet", x => x.userBetID);
                    table.ForeignKey(
                        name: "FK_DBUserBet_DBBettingTicket_bettingTicketID",
                        column: x => x.bettingTicketID,
                        principalTable: "DBBettingTicket",
                        principalColumn: "bettingTicketID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DBUserBet_DBFootballEventBet_footballEventBetID",
                        column: x => x.footballEventBetID,
                        principalTable: "DBFootballEventBet",
                        principalColumn: "footballEventBetID",
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
                name: "IX_DBEventt_bettingEventStatusID",
                table: "DBEventt",
                column: "bettingEventStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_DBEventt_sportID",
                table: "DBEventt",
                column: "sportID");

            migrationBuilder.CreateIndex(
                name: "IX_DBFootballEvent_eventtID",
                table: "DBFootballEvent",
                column: "eventtID");

            migrationBuilder.CreateIndex(
                name: "IX_DBFootballEvent_footballLeagueID",
                table: "DBFootballEvent",
                column: "footballLeagueID");

            migrationBuilder.CreateIndex(
                name: "IX_DBFootballEvent_footballTeam0ID",
                table: "DBFootballEvent",
                column: "footballTeam0ID");

            migrationBuilder.CreateIndex(
                name: "IX_DBFootballEvent_footballTeam1ID",
                table: "DBFootballEvent",
                column: "footballTeam1ID");

            migrationBuilder.CreateIndex(
                name: "IX_DBFootballEventBet_betID",
                table: "DBFootballEventBet",
                column: "betID");

            migrationBuilder.CreateIndex(
                name: "IX_DBFootballEventBet_footballEventID",
                table: "DBFootballEventBet",
                column: "footballEventID");

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
                name: "IX_DBUserBet_bettingTicketID",
                table: "DBUserBet",
                column: "bettingTicketID");

            migrationBuilder.CreateIndex(
                name: "IX_DBUserBet_footballEventBetID",
                table: "DBUserBet",
                column: "footballEventBetID");
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
                name: "DBBettingTicket");

            migrationBuilder.DropTable(
                name: "DBFootballEventBet");

            migrationBuilder.DropTable(
                name: "DBAccountDetails");

            migrationBuilder.DropTable(
                name: "DBBet");

            migrationBuilder.DropTable(
                name: "DBFootballEvent");

            migrationBuilder.DropTable(
                name: "DBBetType");

            migrationBuilder.DropTable(
                name: "DBEventt");

            migrationBuilder.DropTable(
                name: "DBFootballTeam");

            migrationBuilder.DropTable(
                name: "DBBettingEventStatus");

            migrationBuilder.DropTable(
                name: "DBFootballLeague");

            migrationBuilder.DropTable(
                name: "DBCountry");

            migrationBuilder.DropTable(
                name: "DBSport");
        }
    }
}
