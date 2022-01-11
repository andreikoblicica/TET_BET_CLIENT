using System.Collections.Generic;
using TET_BET.Models;

namespace TET_BET.ControllersModels.MainMenuModel
{
    public class MainMenuModel
    {
        public List<MatchInfo> MatchInfos { get; set; }
        public List<BettingTicketBetModel> BettingTicketBetList { get; set; }
    }
}