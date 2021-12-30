using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TET_BET.Models;

namespace TET_BET.Controllers
{
    public class MainMenuController : Controller
    {

        public List<DBFootballEvent> currentBetMatches = new List<DBFootballEvent>();
        public List<DBBet> currentBets = new List<DBBet>();
        
        public List<DBFootballEvent> GetAllMatches()
        {
            List<DBFootballEvent> matches = new List<DBFootballEvent>();
            matches.Add(new DBFootballEvent()
            {
                footballTeam0 = new DBFootballTeam()
                {
                    footballTeamName = "Chelsea"
                },
                footballTeam1 = new DBFootballTeam()
                {
                    footballTeamName = "Liverpool"
                },
                eventt = new DBEventt()
                {
                    bettingEventDate = DateTime.Now
                }
            });
            matches.Add(new DBFootballEvent()
            {
                footballTeam0 = new DBFootballTeam()
                {
                    footballTeamName = "Tottenham"
                },
                footballTeam1 = new DBFootballTeam()
                {
                    footballTeamName = "Arsenal"
                },
                eventt = new DBEventt()
                {
                    bettingEventDate = DateTime.Now
                }
            });
            matches.Add(new DBFootballEvent()
            {
                footballTeam0 = new DBFootballTeam()
                {
                    footballTeamName = "Manchester City"
                },
                footballTeam1 = new DBFootballTeam()
                {
                    footballTeamName = "Manchester United"
                },
                eventt = new DBEventt()
                {
                    bettingEventDate = DateTime.Now
                }
            });
            return matches;
        }

        
      
        
        public IActionResult MainMenu()
        {
            ViewData["matches"] = GetAllMatches();
            return View();
        }
    }
}