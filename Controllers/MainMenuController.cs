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




        public IActionResult MainMenu()
        {
            return View();
        }
    }


}