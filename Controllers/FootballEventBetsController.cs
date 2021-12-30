using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TET_BET.Models;

namespace TET_BET.Controllers
{
    public class FootballEventBetsController : Controller
    {
        private DBFootballEvent getDummyFootballEvent()
        {
            return new DBFootballEvent
            {
                eventt = new DBEventt
                {
                    sport = new DBSport()
                    {
                        sportName = "football"
                    },
                    bettingEventDate = DateTime.Now,
                    bettingEventLocation = "Stamford Bridge",
                    bettingEventStatus = new DBBettingEventStatus()
                    {
                        bettingEventStatusMessage = "In progress"
                    }
                },
                footballTeam0 = new DBFootballTeam()
                {
                    footballLeague = new DBFootballLeague()
                    {
                        country = new DBCountry()
                        {
                            countryName = "England"
                        },
                        season = 2021,
                        leagueName = "Premier League"
                    },
                    footballTeamName = "Chelsea"
                },
                footballTeam1 = new DBFootballTeam()
                {
                    footballLeague = new DBFootballLeague()
                    {
                        country = new DBCountry()
                        {
                            countryName = "England"
                        },
                        season = 2021,
                        leagueName = "Premier League"
                    },
                    footballTeamName = "Liverpool"
                }

            };
            
        }

        private List<DBBetType> getDummyBets()
        {
            List<DBBet> betsList = new List<DBBet>();
            List<DBBet> betsList2 = new List<DBBet>();
            List<DBBet> betsList3 = new List<DBBet>();
            betsList.Add(new DBBet()
            {
                betName = "Home",
                oddValue = (float) 1.5
            });
            betsList.Add(new DBBet()
            {
                betName = "Draw",
                oddValue = (float) 3
            });
            betsList.Add(new DBBet()
            {
                betName = "Away",
                oddValue = (float) 7.5
            });
            betsList2.Add(new DBBet()
            {
                betName = "Yes",
                oddValue = (float) 1.75
            });
            betsList2.Add(new DBBet()
            {
                betName = "No",
                oddValue = (float) 1.95
            });
            betsList3.Add(new DBBet()
            {
                betName = "0-0",
                oddValue = (float) 4.3
            });
            betsList3.Add(new DBBet()
            {
                betName = "1-0",
                oddValue = (float) 2.2
            });
            betsList3.Add(new DBBet()
            {
                betName = "2-0",
                oddValue = (float) 2.6
            });
            betsList3.Add(new DBBet()
            {
                betName = "3-0",
                oddValue = (float) 6.5
            });
            List<DBBetType> bets = new List<DBBetType>();
            bets.Add(new DBBetType()
            {
                betTypeName = "Match Winner",
                betsList = betsList
            });
            bets.Add(new DBBetType()
            {
                betTypeName = "Both Teams Score",
                betsList = betsList2
            });
            bets.Add(new DBBetType()
            {
                betTypeName = "Exact Score",
                betsList = betsList3
            });
            return bets;
        }
        public IActionResult FootballEventBets()
        {
            ViewData["football_event"] = getDummyFootballEvent();
            ViewData["bets_list"] = getDummyBets();
            return View();
        }
        
    }
}