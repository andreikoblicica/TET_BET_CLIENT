using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TET_BET.ControllersModels.MainMenuModel;
using TET_BET.Models;
using TET_BET.Service.Events;

namespace TET_BET.Controllers
{
    public class MainMenuController : Controller
    {
        public List<DBFootballEvent> currentBetMatches = new List<DBFootballEvent>();
        public List<DBBet> currentBets = new List<DBBet>();


       

        public IActionResult MainMenu()
        {
            FootballEvent footballEvent = new FootballEvent();
            MainMenuModel model = new MainMenuModel();
            model.MatchInfos = footballEvent.GetFilteredFootballEventsBet(1,0,2);
            return View(model);
        }
    }


}