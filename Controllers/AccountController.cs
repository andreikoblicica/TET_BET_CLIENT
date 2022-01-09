// using System;
// using System.Collections.Generic;
// using Microsoft.AspNetCore.Mvc;
// using TET_BET.Models;
//
// namespace TET_BET.Controllers
// {
//     public class AccountController: Controller
//     {
//         private List<DBBettingTicket> getTickets()
//         {
//             List<DBBettingTicket> tickets = new List<DBBettingTicket>();
//              List<DBUserBet> bets = new List<DBUserBet>();
//             bets.Add(new DBUserBet()
//             {
//                 bet = new DBBet()
//                 {
//                     betName = "Away",
//                     oddValue = (float)1.44,
//                     betType = new DBBetType()
//                     {
//                         betTypeName = "Match Winner"
//                     }
//                 },
//                 footballEvent = new DBFootballEvent()
//                 {
//                     footballTeam0 = new DBFootballTeam()
//                     {
//                         footballTeamName = "Manchester City"
//                     },
//                     footballTeam1 = new DBFootballTeam()
//                     {
//                         footballTeamName = "Manchester United"
//                     }
//                 }
//             });
//            bets.Add(new DBUserBet()
//            {
//                bet = new DBBet()
//                {
//                    betName = "Home",
//                    oddValue = (float)3.21,
//                    betType = new DBBetType()
//                    {
//                        betTypeName = "Match Winner"
//                    }
//                },
//                footballEvent = new DBFootballEvent()
//                {
//                    footballTeam0 = new DBFootballTeam()
//                    {
//                        footballTeamName = "Chelsea"
//                    },
//                    footballTeam1 = new DBFootballTeam()
//                    {
//                        footballTeamName = "Liverpool"
//                    }
//                }
//            });
//            bets.Add(new DBUserBet()
//            {
//                bet = new DBBet()
//                {
//                    betName = "Yes",
//                    oddValue = (float)2.00,
//                    betType = new DBBetType()
//                    {
//                        betTypeName = "Both Teams Score"
//                    }
//                },
//                footballEvent = new DBFootballEvent()
//                {
//                    footballTeam0 = new DBFootballTeam()
//                    {
//                        footballTeamName = "Tottenham"
//                    },
//                    footballTeam1 = new DBFootballTeam()
//                    {
//                        footballTeamName = "Arsenal"
//                    }
//                }
//            });
//            bets.Add(new DBUserBet()
//            {
//                bet = new DBBet()
//                {
//                    betName = "2-0",
//                    oddValue = (float)5.45,
//                    betType = new DBBetType()
//                    {
//                        betTypeName = "Correct Score"
//                    }
//                },
//                footballEvent = new DBFootballEvent()
//                {
//                    footballTeam0 = new DBFootballTeam()
//                    {
//                        footballTeamName = "Aston Villa"
//                    },
//                    footballTeam1 = new DBFootballTeam()
//                    {
//                        footballTeamName = "Everton"
//                    }
//                }
//            });
//            DBBettingTicket ticket = new DBBettingTicket()
//            {
//                bettingTicketBetsList = bets,
//                isClosed = true,
//                isWinner = true,
//                bettingTicketDate = new DateTime(2021,12,18,19,22,10),
//                bettingTicketID = 1,
//                bettingTicketSum = 30
//            };
//             ///////////
//              List<DBUserBet> bets2 = new List<DBUserBet>();
//             bets2.Add(new DBUserBet()
//             {
//                 bet = new DBBet()
//                 {
//                     betName = "Draw",
//                     oddValue = (float)1.70,
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
//            bets2.Add(new DBUserBet()
//            {
//                bet = new DBBet()
//                {
//                    betName = "No",
//                    oddValue = (float)2.25,
//                    betType = new DBBetType()
//                    {
//                        betTypeName = "Both Teams Score"
//                    }
//                },
//                footballEvent = new DBFootballEvent()
//                {
//                    footballTeam0 = new DBFootballTeam()
//                    {
//                        footballTeamName = "Watford"
//                    },
//                    footballTeam1 = new DBFootballTeam()
//                    {
//                        footballTeamName = "Leicester City"
//                    }
//                }
//            });
//            
//            DBBettingTicket ticket2 = new DBBettingTicket()
//            {
//                bettingTicketBetsList = bets2,
//                isClosed = true,
//                isWinner = false,
//                bettingTicketDate = new DateTime(2021,12,26,21,44,50),
//                bettingTicketID = 2,
//                bettingTicketSum = 25
//            };
//            /////////
//             List<DBUserBet> bets3 = new List<DBUserBet>();
//             bets3.Add(new DBUserBet()
//             {
//                 bet = new DBBet()
//                 {
//                     betName = "0-0",
//                     oddValue = (float)5.65,
//                     betType = new DBBetType()
//                     {
//                         betTypeName = "Correct Score"
//                     }
//                 },
//                 footballEvent = new DBFootballEvent()
//                 {
//                     footballTeam0 = new DBFootballTeam()
//                     {
//                         footballTeamName = "Burnley"
//                     },
//                     footballTeam1 = new DBFootballTeam()
//                     {
//                         footballTeamName = "Southampton"
//                     }
//                 }
//             });
//            bets3.Add(new DBUserBet()
//            {
//                bet = new DBBet()
//                {
//                    betName = "3-0",
//                    oddValue = (float)7.80,
//                    betType = new DBBetType()
//                    {
//                        betTypeName = "Correct Score"
//                    }
//                },
//                footballEvent = new DBFootballEvent()
//                {
//                    footballTeam0 = new DBFootballTeam()
//                    {
//                        footballTeamName = "Aston Villa"
//                    },
//                    footballTeam1 = new DBFootballTeam()
//                    {
//                        footballTeamName = "Everton"
//                    }
//                }
//            });
//            bets3.Add(new DBUserBet()
//            {
//                bet = new DBBet()
//                {
//                    betName = "Away",
//                    oddValue = (float)1.25,
//                    betType = new DBBetType()
//                    {
//                        betTypeName = "Match Winner"
//                    }
//                },
//                footballEvent = new DBFootballEvent()
//                {
//                    footballTeam0 = new DBFootballTeam()
//                    {
//                        footballTeamName = "Tottenham"
//                    },
//                    footballTeam1 = new DBFootballTeam()
//                    {
//                        footballTeamName = "Arsenal"
//                    }
//                }
//            });
//            
//            DBBettingTicket ticket3 = new DBBettingTicket()
//            {
//                bettingTicketBetsList = bets3,
//                isClosed = false,
//                bettingTicketDate = new DateTime(2022,01,01,16,30,02),
//                bettingTicketID = 3,
//                bettingTicketSum = 50
//            };
//             tickets.Add(ticket);
//             tickets.Add(ticket2);
//             tickets.Add(ticket3);
//             return tickets;
//         }
//         private List<DBTransaction> getTransactions()
//         {
//             List<DBTransaction> transactions = new List<DBTransaction>();
//             transactions.Add(new DBTransaction()
//             {
//                 transactionDate = new DateTime(2021,12,16,19,34,22),
//                 transactionSum = 100
//             });
//             transactions.Add(new DBTransaction()
//             {
//                 transactionDate = new DateTime(2021,12,22,11,23,11),
//                 transactionSum = 300
//             });
//             transactions.Add(new DBTransaction()
//             {
//                 transactionDate = new DateTime(2021,12,28,23,45,00),
//                 transactionSum = -(float)1631.53
//             });
//             transactions.Add(new DBTransaction()
//             {
//                 transactionDate = new DateTime(2022,01,01,09,21,12),
//                 transactionSum = +50
//             });
//             transactions.Add(new DBTransaction()
//             {
//                 transactionDate = new DateTime(2022,01,02,13,55,40),
//                 transactionSum = -250
//             });
//             return transactions;
//         }
//         public IActionResult Account()
//         {
//             ViewData["tickets"] = getTickets();
//             ViewData["transactions"] = getTransactions();
//             return View();
//         }
//     }
// }