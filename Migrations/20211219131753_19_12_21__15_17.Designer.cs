﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TET_BET;

namespace TET_BET.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20211219131753_19_12_21__15_17")]
    partial class _19_12_21__15_17
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("TET_BET.Models.DBAccountDetails", b =>
                {
                    b.Property<int>("accountDetailsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("accountBalance")
                        .HasColumnType("float");

                    b.Property<DateTime>("dateRegistered")
                        .HasColumnType("datetime");

                    b.HasKey("accountDetailsID");

                    b.ToTable("DBAccountDetails");
                });

            modelBuilder.Entity("TET_BET.Models.DBBet", b =>
                {
                    b.Property<int>("betID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("betName")
                        .HasColumnType("text");

                    b.Property<int?>("betTypeID")
                        .HasColumnType("int");

                    b.HasKey("betID");

                    b.HasIndex("betTypeID");

                    b.ToTable("DBBet");
                });

            modelBuilder.Entity("TET_BET.Models.DBBetType", b =>
                {
                    b.Property<int>("betTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("betTypeName")
                        .HasColumnType("text");

                    b.Property<int?>("sportID")
                        .HasColumnType("int");

                    b.HasKey("betTypeID");

                    b.HasIndex("sportID");

                    b.ToTable("DBBetType");
                });

            modelBuilder.Entity("TET_BET.Models.DBBettingEventStatus", b =>
                {
                    b.Property<int>("bettingEventStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("bettingEventStatusDescription")
                        .HasColumnType("text");

                    b.Property<string>("bettingEventStatusMessage")
                        .HasColumnType("text");

                    b.HasKey("bettingEventStatusID");

                    b.ToTable("DBBettingEventStatus");
                });

            modelBuilder.Entity("TET_BET.Models.DBBettingTicket", b =>
                {
                    b.Property<int>("bettingTicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("accountDetailsID")
                        .HasColumnType("int");

                    b.Property<DateTime>("bettingTicketDate")
                        .HasColumnType("datetime");

                    b.Property<float>("bettingTicketSum")
                        .HasColumnType("float");

                    b.HasKey("bettingTicketID");

                    b.HasIndex("accountDetailsID");

                    b.ToTable("DBBettingTicket");
                });

            modelBuilder.Entity("TET_BET.Models.DBCountry", b =>
                {
                    b.Property<int>("countryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("countryName")
                        .HasColumnType("text");

                    b.Property<string>("rapidAPICode")
                        .HasColumnType("text");

                    b.HasKey("countryID");

                    b.ToTable("DBCountry");
                });

            modelBuilder.Entity("TET_BET.Models.DBEvent", b =>
                {
                    b.Property<int>("eventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("bettingEventDate")
                        .HasColumnType("datetime");

                    b.Property<string>("bettingEventLocation")
                        .HasColumnType("text");

                    b.Property<int>("bettingEventStatusID")
                        .HasColumnType("int");

                    b.Property<int>("sportID")
                        .HasColumnType("int");

                    b.HasKey("eventID");

                    b.HasIndex("bettingEventStatusID");

                    b.HasIndex("sportID");

                    b.ToTable("DBEvent");
                });

            modelBuilder.Entity("TET_BET.Models.DBEventLookUpTable", b =>
                {
                    b.Property<int>("eventLookUpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("footballEventID")
                        .HasColumnType("int");

                    b.HasKey("eventLookUpID");

                    b.HasIndex("footballEventID");

                    b.ToTable("DBEventLookUpTable");
                });

            modelBuilder.Entity("TET_BET.Models.DBFootballEvent", b =>
                {
                    b.Property<int>("footballEventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("footballLeagueID")
                        .HasColumnType("int");

                    b.Property<int?>("footballTeam0footballTeamID")
                        .HasColumnType("int");

                    b.Property<int?>("footballTeam1footballTeamID")
                        .HasColumnType("int");

                    b.HasKey("footballEventID");

                    b.HasIndex("footballLeagueID");

                    b.HasIndex("footballTeam0footballTeamID");

                    b.HasIndex("footballTeam1footballTeamID");

                    b.ToTable("DBFootballEvent");
                });

            modelBuilder.Entity("TET_BET.Models.DBFootballLeague", b =>
                {
                    b.Property<int>("footballLeagueID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("countryID")
                        .HasColumnType("int");

                    b.Property<string>("leagueName")
                        .HasColumnType("text");

                    b.Property<int>("nrTeams")
                        .HasColumnType("int");

                    b.Property<int>("rapidAPIID")
                        .HasColumnType("int");

                    b.Property<int>("season")
                        .HasColumnType("int");

                    b.Property<int>("sportID")
                        .HasColumnType("int");

                    b.HasKey("footballLeagueID");

                    b.HasIndex("countryID");

                    b.HasIndex("sportID");

                    b.ToTable("DBFootballLeague");
                });

            modelBuilder.Entity("TET_BET.Models.DBFootballPlayer", b =>
                {
                    b.Property<int>("footballPlayerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("countryID")
                        .HasColumnType("int");

                    b.Property<string>("footballPlayerName")
                        .HasColumnType("text");

                    b.Property<int?>("footballTeamID")
                        .HasColumnType("int");

                    b.HasKey("footballPlayerID");

                    b.HasIndex("countryID");

                    b.HasIndex("footballTeamID");

                    b.ToTable("DBFootballPlayer");
                });

            modelBuilder.Entity("TET_BET.Models.DBFootballTeam", b =>
                {
                    b.Property<int>("footballTeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("footballLeagueID")
                        .HasColumnType("int");

                    b.Property<string>("footballTeamManagerName")
                        .HasColumnType("text");

                    b.Property<string>("footballTeamName")
                        .HasColumnType("text");

                    b.Property<string>("footballTeamStadiumName")
                        .HasColumnType("text");

                    b.HasKey("footballTeamID");

                    b.HasIndex("footballLeagueID");

                    b.ToTable("DBFootballTeam");
                });

            modelBuilder.Entity("TET_BET.Models.DBSport", b =>
                {
                    b.Property<int>("sportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("sportName")
                        .HasColumnType("text");

                    b.HasKey("sportID");

                    b.ToTable("DBSport");
                });

            modelBuilder.Entity("TET_BET.Models.DBTransaction", b =>
                {
                    b.Property<int>("transactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("accountDetailsID")
                        .HasColumnType("int");

                    b.Property<DateTime>("transactionDate")
                        .HasColumnType("datetime");

                    b.Property<float>("transactionSum")
                        .HasColumnType("float");

                    b.HasKey("transactionID");

                    b.HasIndex("accountDetailsID");

                    b.ToTable("DBTransaction");
                });

            modelBuilder.Entity("TET_BET.Models.DBUser", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("accountDetailsID")
                        .HasColumnType("int");

                    b.Property<string>("userEmail")
                        .HasColumnType("text");

                    b.Property<string>("userPassword")
                        .HasColumnType("text");

                    b.HasKey("userID");

                    b.HasIndex("accountDetailsID")
                        .IsUnique();

                    b.ToTable("DBUser");
                });

            modelBuilder.Entity("TET_BET.Models.DBUserBet", b =>
                {
                    b.Property<int>("userBetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("betID")
                        .HasColumnType("int");

                    b.Property<int?>("bettingTicketID")
                        .HasColumnType("int");

                    b.Property<int?>("dbEventeventID")
                        .HasColumnType("int");

                    b.Property<int>("eventID")
                        .HasColumnType("int");

                    b.Property<int>("eventLookUpID")
                        .HasColumnType("int");

                    b.Property<float>("oddValue")
                        .HasColumnType("float");

                    b.HasKey("userBetID");

                    b.HasIndex("betID");

                    b.HasIndex("bettingTicketID");

                    b.HasIndex("dbEventeventID");

                    b.HasIndex("eventLookUpID");

                    b.ToTable("DBUserBet");
                });

            modelBuilder.Entity("TET_BET.Models.DBBet", b =>
                {
                    b.HasOne("TET_BET.Models.DBBetType", "betType")
                        .WithMany("betsList")
                        .HasForeignKey("betTypeID");

                    b.Navigation("betType");
                });

            modelBuilder.Entity("TET_BET.Models.DBBetType", b =>
                {
                    b.HasOne("TET_BET.Models.DBSport", "sport")
                        .WithMany()
                        .HasForeignKey("sportID");

                    b.Navigation("sport");
                });

            modelBuilder.Entity("TET_BET.Models.DBBettingTicket", b =>
                {
                    b.HasOne("TET_BET.Models.DBAccountDetails", "accountDetails")
                        .WithMany("bettingTicketsList")
                        .HasForeignKey("accountDetailsID");

                    b.Navigation("accountDetails");
                });

            modelBuilder.Entity("TET_BET.Models.DBEvent", b =>
                {
                    b.HasOne("TET_BET.Models.DBBettingEventStatus", "bettingEventStatus")
                        .WithMany()
                        .HasForeignKey("bettingEventStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TET_BET.Models.DBSport", "sport")
                        .WithMany()
                        .HasForeignKey("sportID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bettingEventStatus");

                    b.Navigation("sport");
                });

            modelBuilder.Entity("TET_BET.Models.DBEventLookUpTable", b =>
                {
                    b.HasOne("TET_BET.Models.DBFootballEvent", "footballEvent")
                        .WithMany()
                        .HasForeignKey("footballEventID");

                    b.Navigation("footballEvent");
                });

            modelBuilder.Entity("TET_BET.Models.DBFootballEvent", b =>
                {
                    b.HasOne("TET_BET.Models.DBFootballLeague", "footballLeague")
                        .WithMany()
                        .HasForeignKey("footballLeagueID");

                    b.HasOne("TET_BET.Models.DBFootballTeam", "footballTeam0")
                        .WithMany()
                        .HasForeignKey("footballTeam0footballTeamID");

                    b.HasOne("TET_BET.Models.DBFootballTeam", "footballTeam1")
                        .WithMany()
                        .HasForeignKey("footballTeam1footballTeamID");

                    b.Navigation("footballLeague");

                    b.Navigation("footballTeam0");

                    b.Navigation("footballTeam1");
                });

            modelBuilder.Entity("TET_BET.Models.DBFootballLeague", b =>
                {
                    b.HasOne("TET_BET.Models.DBCountry", "country")
                        .WithMany()
                        .HasForeignKey("countryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TET_BET.Models.DBSport", "sport")
                        .WithMany()
                        .HasForeignKey("sportID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");

                    b.Navigation("sport");
                });

            modelBuilder.Entity("TET_BET.Models.DBFootballPlayer", b =>
                {
                    b.HasOne("TET_BET.Models.DBCountry", "country")
                        .WithMany()
                        .HasForeignKey("countryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TET_BET.Models.DBFootballTeam", "footballTeam")
                        .WithMany("footballPlayersList")
                        .HasForeignKey("footballTeamID");

                    b.Navigation("country");

                    b.Navigation("footballTeam");
                });

            modelBuilder.Entity("TET_BET.Models.DBFootballTeam", b =>
                {
                    b.HasOne("TET_BET.Models.DBFootballLeague", "footballLeague")
                        .WithMany("footballTeamsList")
                        .HasForeignKey("footballLeagueID");

                    b.Navigation("footballLeague");
                });

            modelBuilder.Entity("TET_BET.Models.DBTransaction", b =>
                {
                    b.HasOne("TET_BET.Models.DBAccountDetails", "accountDetails")
                        .WithMany("transactionsList")
                        .HasForeignKey("accountDetailsID");

                    b.Navigation("accountDetails");
                });

            modelBuilder.Entity("TET_BET.Models.DBUser", b =>
                {
                    b.HasOne("TET_BET.Models.DBAccountDetails", "accountDetails")
                        .WithOne("user")
                        .HasForeignKey("TET_BET.Models.DBUser", "accountDetailsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("accountDetails");
                });

            modelBuilder.Entity("TET_BET.Models.DBUserBet", b =>
                {
                    b.HasOne("TET_BET.Models.DBBet", "bet")
                        .WithMany()
                        .HasForeignKey("betID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TET_BET.Models.DBBettingTicket", "bettingTicket")
                        .WithMany("bettingTicketBetsList")
                        .HasForeignKey("bettingTicketID");

                    b.HasOne("TET_BET.Models.DBEvent", "dbEvent")
                        .WithMany()
                        .HasForeignKey("dbEventeventID");

                    b.HasOne("TET_BET.Models.DBEventLookUpTable", "eventLookUp")
                        .WithMany()
                        .HasForeignKey("eventLookUpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bet");

                    b.Navigation("bettingTicket");

                    b.Navigation("dbEvent");

                    b.Navigation("eventLookUp");
                });

            modelBuilder.Entity("TET_BET.Models.DBAccountDetails", b =>
                {
                    b.Navigation("bettingTicketsList");

                    b.Navigation("transactionsList");

                    b.Navigation("user");
                });

            modelBuilder.Entity("TET_BET.Models.DBBetType", b =>
                {
                    b.Navigation("betsList");
                });

            modelBuilder.Entity("TET_BET.Models.DBBettingTicket", b =>
                {
                    b.Navigation("bettingTicketBetsList");
                });

            modelBuilder.Entity("TET_BET.Models.DBFootballLeague", b =>
                {
                    b.Navigation("footballTeamsList");
                });

            modelBuilder.Entity("TET_BET.Models.DBFootballTeam", b =>
                {
                    b.Navigation("footballPlayersList");
                });
#pragma warning restore 612, 618
        }
    }
}
