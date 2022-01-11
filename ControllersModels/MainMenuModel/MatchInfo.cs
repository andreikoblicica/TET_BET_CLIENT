using System;
using System.Collections.Generic;

namespace TET_BET.ControllersModels.MainMenuModel
{
    public class MatchInfo
    {
        public DateTime DateTime;
        public string TeamName0;
        public string TeamName1;

        public List<MatchesListBet> HomeControllerBets = new List<MatchesListBet>();
    }
}