using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TET_BET.ControllersModels.FootballEventBetsModel;
using TET_BET.Models;
using TET_BET.Service.Events;

namespace TET_BET.Controllers
{
    public class FootballEventBetsController : Controller
    {
       
        
        public IActionResult FootballEventBets()
        {
            FootballEvent footballEvent = new FootballEvent();
            
            FootballEventBetsModel footballEventBetsModel = new FootballEventBetsModel();
            footballEventBetsModel.betTypes = footballEvent.GetBetTypes(3);
            DBFootballEvent dbFootballEvent = footballEvent.GetEventByID(3);
            footballEventBetsModel.teamName0 = dbFootballEvent.footballTeam0.footballTeamName;
            footballEventBetsModel.teamName1 = dbFootballEvent.footballTeam1.footballTeamName;
            footballEventBetsModel.bettingEventDate = dbFootballEvent.eventt.bettingEventDate;
            footballEventBetsModel.bettingEventLocation = dbFootballEvent.eventt.bettingEventLocation;
            return View(footballEventBetsModel);
        }
        
    }
}