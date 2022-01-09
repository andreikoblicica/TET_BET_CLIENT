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
    [Migration("20220102183020_02_01_2022__20_27")]
    partial class _02_01_2022__20_27
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

                    b.Property<int>("rapidAPIBetID")
                        .HasColumnType("int");

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

                    b.Property<bool>("isWinner")
                        .HasColumnType("tinyint(1)");

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

            modelBuilder.Entity("TET_BET.Models.DBEventt", b =>
                {
                    b.Property<int>("eventtID")
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

                    b.HasKey("eventtID");

                    b.HasIndex("bettingEventStatusID");

                    b.HasIndex("sportID");

                    b.ToTable("DBEventt");
                });

            modelBuilder.Entity("TET_BET.Models.DBFootballEvent", b =>
                {
                    b.Property<int>("footballEventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("eventtID")
                        .HasColumnType("int");

                    b.Property<int?>("footballLeagueID")
                        .HasColumnType("int");

                    b.Property<int>("footballTeam0ID")
                        .HasColumnType("int");

                    b.Property<int>("footballTeam1ID")
                        .HasColumnType("int");

                    b.Property<int>("goalsTeam0FirstHalf")
                        .HasColumnType("int");

                    b.Property<int>("goalsTeam0SecondHalf")
                        .HasColumnType("int");

                    b.Property<int>("goalsTeam1FirstHalf")
                        .HasColumnType("int");

                    b.Property<int>("goalsTeam1SecondHalf")
                        .HasColumnType("int");

                    b.Property<int>("rapidAPIFixtureID")
                        .HasColumnType("int");

                    b.HasKey("footballEventID");

                    b.HasIndex("eventtID");

                    b.HasIndex("footballLeagueID");

                    b.HasIndex("footballTeam0ID");

                    b.HasIndex("footballTeam1ID");

                    b.ToTable("DBFootballEvent");
                });

            modelBuilder.Entity("TET_BET.Models.DBFootballEventBet", b =>
                {
                    b.Property<int>("footballEventBetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("betID")
                        .HasColumnType("int");

                    b.Property<int>("footballEventID")
                        .HasColumnType("int");

                    b.Property<float>("oddValue")
                        .HasColumnType("float");

                    b.HasKey("footballEventBetID");

                    b.HasIndex("betID");

                    b.HasIndex("footballEventID");

                    b.ToTable("DBFootballEventBet");
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

                    b.Property<int>("rapidAPIID")
                        .HasColumnType("int");

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

                    b.Property<int>("accountDetailsID")
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

                    b.Property<int>("bettingTicketID")
                        .HasColumnType("int");

                    b.Property<int>("footballEventBetID")
                        .HasColumnType("int");

                    b.Property<bool>("isWinner")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("userBetID");

                    b.HasIndex("bettingTicketID");

                    b.HasIndex("footballEventBetID");

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

            modelBuilder.Entity("TET_BET.Models.DBEventt", b =>
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

            modelBuilder.Entity("TET_BET.Models.DBFootballEvent", b =>
                {
                    b.HasOne("TET_BET.Models.DBEventt", "eventt")
                        .WithMany()
                        .HasForeignKey("eventtID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TET_BET.Models.DBFootballLeague", "footballLeague")
                        .WithMany()
                        .HasForeignKey("footballLeagueID");

                    b.HasOne("TET_BET.Models.DBFootballTeam", "footballTeam0")
                        .WithMany()
                        .HasForeignKey("footballTeam0ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TET_BET.Models.DBFootballTeam", "footballTeam1")
                        .WithMany()
                        .HasForeignKey("footballTeam1ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("eventt");

                    b.Navigation("footballLeague");

                    b.Navigation("footballTeam0");

                    b.Navigation("footballTeam1");
                });

            modelBuilder.Entity("TET_BET.Models.DBFootballEventBet", b =>
                {
                    b.HasOne("TET_BET.Models.DBBet", "bet")
                        .WithMany()
                        .HasForeignKey("betID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TET_BET.Models.DBFootballEvent", "footballEvent")
                        .WithMany()
                        .HasForeignKey("footballEventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bet");

                    b.Navigation("footballEvent");
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
                        .HasForeignKey("accountDetailsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                    b.HasOne("TET_BET.Models.DBBettingTicket", "bettingTicket")
                        .WithMany("bettingTicketBetsList")
                        .HasForeignKey("bettingTicketID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TET_BET.Models.DBFootballEventBet", "footballEventBet")
                        .WithMany()
                        .HasForeignKey("footballEventBetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bettingTicket");

                    b.Navigation("footballEventBet");
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