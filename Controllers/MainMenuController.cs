// using System;
// using System.Collections.Generic;
// using Microsoft.AspNetCore.Mvc;
// using TET_BET.Models;
//
// namespace TET_BET.Controllers
// {
//     public class MainMenuController : Controller
//     {
//         public List<DBFootballEvent> currentBetMatches = new List<DBFootballEvent>();
//         public List<DBBet> currentBets = new List<DBBet>();
//
//         public List<DBFootballEvent> GetAllMatches()
//         {
//             List<DBFootballEvent> matches = new List<DBFootballEvent>();
//             List<DBBet> betsList = new List<DBBet>();
//             betsList.Add(new DBBet()
//             {
//                 betName = "Home",
//                 oddValue = (float) 2.80
//             });
//             betsList.Add(new DBBet()
//             {
//                 betName = "Draw",
//                 oddValue = (float) 3.20
//             });
//             betsList.Add(new DBBet()
//             {
//                 betName = "Away",
//                 oddValue = (float) 2.60
//             });
//
//             matches.Add(new DBFootballEvent()
//             {
//                 footballTeam0 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Chelsea"
//                 },
//                 footballTeam1 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Liverpool"
//                 },
//                 eventt = new DBEventt()
//                 {
//                     bettingEventDate = new DateTime(2022, 01, 02, 19, 30, 00)
//                 },
//                 bets = betsList
//             });
//             List<DBBet> betsList2 = new List<DBBet>();
//             betsList2.Add(new DBBet()
//             {
//                 betName = "Home",
//                 oddValue = (float) 2.00
//             });
//             betsList2.Add(new DBBet()
//             {
//                 betName = "Draw",
//                 oddValue = (float) 3.50
//             });
//             betsList2.Add(new DBBet()
//             {
//                 betName = "Away",
//                 oddValue = (float) 3.60
//             });
//             matches.Add(new DBFootballEvent()
//             {
//                 footballTeam0 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Leeds United"
//                 },
//                 footballTeam1 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Burnley"
//                 },
//                 eventt = new DBEventt()
//                 {
//                     bettingEventDate = new DateTime(2022, 01, 02, 17, 00, 00)
//                 },
//                 bets = betsList2
//             });
//             List<DBBet> betsList3 = new List<DBBet>();
//             betsList3.Add(new DBBet()
//             {
//                 betName = "Home",
//                 oddValue = (float) 3.00
//             });
//             betsList3.Add(new DBBet()
//             {
//                 betName = "Draw",
//                 oddValue = (float) 3.10
//             });
//             betsList3.Add(new DBBet()
//             {
//                 betName = "Away",
//                 oddValue = (float) 2.50
//             });
//             matches.Add(new DBFootballEvent()
//             {
//                 footballTeam0 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Everton"
//                 },
//                 footballTeam1 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Brighton & Hove Albion"
//                 },
//                 eventt = new DBEventt()
//                 {
//                     bettingEventDate = new DateTime(2022, 01, 02, 17, 00, 00)
//                 },
//                 bets = betsList3
//             });
//             List<DBBet> betsList4 = new List<DBBet>();
//             betsList4.Add(new DBBet()
//             {
//                 betName = "Home",
//                 oddValue = (float) 2.80
//             });
//             betsList4.Add(new DBBet()
//             {
//                 betName = "Draw",
//                 oddValue = (float) 3.25
//             });
//             betsList4.Add(new DBBet()
//             {
//                 betName = "Away",
//                 oddValue = (float) 2.55
//             });
//             matches.Add(new DBFootballEvent()
//             {
//                 footballTeam0 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Brentford"
//                 },
//                 footballTeam1 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Aston Villa"
//                 },
//                 eventt = new DBEventt()
//                 {
//                     bettingEventDate = new DateTime(2022, 01, 02, 14, 30, 00)
//                 },
//                 bets = betsList4
//             });
//             List<DBBet> betsList5 = new List<DBBet>();
//             betsList5.Add(new DBBet()
//             {
//                 betName = "Home",
//                 oddValue = (float) 3.40
//             });
//             betsList5.Add(new DBBet()
//             {
//                 betName = "Draw",
//                 oddValue = (float) 3.40
//             });
//             betsList5.Add(new DBBet()
//             {
//                 betName = "Away",
//                 oddValue = (float) 2.15
//             });
//             matches.Add(new DBFootballEvent()
//             {
//                 footballTeam0 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Crystal Palace"
//                 },
//                 footballTeam1 = new DBFootballTeam()
//                 {
//                     footballTeamName = "West Ham United"
//                 },
//                 eventt = new DBEventt()
//                 {
//                     bettingEventDate = new DateTime(2022, 01, 01, 22, 00, 00)
//                 },
//                 bets = betsList5
//             });
//             List<DBBet> betsList6 = new List<DBBet>();
//             betsList6.Add(new DBBet()
//             {
//                 betName = "Home",
//                 oddValue = (float) 5.50
//             });
//             betsList6.Add(new DBBet()
//             {
//                 betName = "Draw",
//                 oddValue = (float) 4.00
//             });
//             betsList6.Add(new DBBet()
//             {
//                 betName = "Away",
//                 oddValue = (float) 1.60
//             });
//             matches.Add(new DBFootballEvent()
//             {
//                 footballTeam0 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Watford"
//                 },
//                 footballTeam1 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Tottenham"
//                 },
//                 eventt = new DBEventt()
//                 {
//                     bettingEventDate = new DateTime(2022, 01, 01, 19, 30, 00)
//                 },
//                 bets = betsList6
//             });
//             List<DBBet> betsList7 = new List<DBBet>();
//             betsList7.Add(new DBBet()
//             {
//                 betName = "Home",
//                 oddValue = (float) 5.25
//             });
//             betsList7.Add(new DBBet()
//             {
//                 betName = "Draw",
//                 oddValue = (float) 4.20
//             });
//             betsList7.Add(new DBBet()
//             {
//                 betName = "Away",
//                 oddValue = (float) 1.60
//             });
//             matches.Add(new DBFootballEvent()
//             {
//                 footballTeam0 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Arsenal"
//                 },
//                 footballTeam1 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Manchester City"
//                 },
//                 eventt = new DBEventt()
//                 {
//                     bettingEventDate = new DateTime(2022, 01, 01, 17, 00, 00)
//                 },
//                 bets = betsList7
//             });
//             List<DBBet> betsList8 = new List<DBBet>();
//             betsList8.Add(new DBBet()
//             {
//                 betName = "Home",
//                 oddValue = (float) 1.65
//             });
//             betsList8.Add(new DBBet()
//             {
//                 betName = "Draw",
//                 oddValue = (float) 3.80
//             });
//             betsList8.Add(new DBBet()
//             {
//                 betName = "Away",
//                 oddValue = (float) 5.25
//             });
//             matches.Add(new DBFootballEvent()
//             {
//                 footballTeam0 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Southampton"
//                 },
//                 footballTeam1 = new DBFootballTeam()
//                 {
//                     footballTeamName = "Newcastle United"
//                 },
//                 eventt = new DBEventt()
//                 {
//                     bettingEventDate = new DateTime(2022, 01, 01, 17, 00, 00)
//                 },
//                 bets = betsList8
//             });
//             return matches;
//         }
//
//
//         public IActionResult MainMenu()
//         {
//             ViewData["ticket"] = GetTicket();
//             ViewData["matches"] = GetAllMatches();
//             return View();
//         }
//
//         private DBBettingTicket GetTicket()
//         {
//             List<DBUserBet> bets = new List<DBUserBet>();
//             bets.Add(new DBUserBet()
//             {
//                 bet = new DBBet()
//                 {
//                     betName = "Away",
//                     oddValue = (float) 2.70,
//                     betType = new DBBetType()
//                     {
//                         betTypeName = "Match Winner"
//                     }
//                 },
//                 footballEvent = new DBFootballEvent()
//                 {
//                     footballTeam0 = new DBFootballTeam()
//                     {
//                         footballTeamName = "Chelsea"
//                     },
//                     footballTeam1 = new DBFootballTeam()
//                     {
//                         footballTeamName = "Liverpool"
//                     }
//                 }
//             });
//             bets.Add(new DBUserBet()
//             {
//                 bet = new DBBet()
//                 {
//                     betName = "Home",
//                     oddValue = (float) 5.25,
//                     betType = new DBBetType()
//                     {
//                         betTypeName = "Match Winner"
//                     }
//                 },
//                 footballEvent = new DBFootballEvent()
//                 {
//                     footballTeam0 = new DBFootballTeam()
//                     {
//                         footballTeamName = "Arsenal"
//                     },
//                     footballTeam1 = new DBFootballTeam()
//                     {
//                         footballTeamName = "Manchester City"
//                     }
//                 }
//             });
//             bets.Add(new DBUserBet()
//             {
//                 bet = new DBBet()
//                 {
//                     betName = "Yes",
//                     oddValue = (float) 2.00,
//                     betType = new DBBetType()
//                     {
//                         betTypeName = "Both Teams Score"
//                     }
//                 },
//                 footballEvent = new DBFootballEvent()
//                 {
//                     footballTeam0 = new DBFootballTeam()
//                     {
//                         footballTeamName = "Southampton"
//                     },
//                     footballTeam1 = new DBFootballTeam()
//                     {
//                         footballTeamName = "Newcastle United"
//                     }
//                 }
//             });
//             bets.Add(new DBUserBet()
//             {
//                 bet = new DBBet()
//                 {
//                     betName = "2-0",
//                     oddValue = (float) 5.45,
//                     betType = new DBBetType()
//                     {
//                         betTypeName = "Correct Score"
//                     }
//                 },
//                 footballEvent = new DBFootballEvent()
//                 {
//                     footballTeam0 = new DBFootballTeam()
//                     {
//                         footballTeamName = "Brentford"
//                     },
//                     footballTeam1 = new DBFootballTeam()
//                     {
//                         footballTeamName = "Aston Villa"
//                     }
//                 }
//             });
//             DBBettingTicket ticket = new DBBettingTicket()
//             {
//                 bettingTicketBetsList = bets
//             };
//             return ticket;
//         }
//     }
// }