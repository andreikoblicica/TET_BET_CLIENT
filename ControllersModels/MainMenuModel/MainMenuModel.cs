using System.Collections.Generic;
using TET_BET.Models;

namespace TET_BET.ControllersModels.MainMenuModel
{
    public class MainMenuModel
    {
        public DBUser user;
        public List<MatchInfo> MatchInfos { get; set; }
        public List<BettingTicketBetModel> BettingTicketBetList { get; set; }
        public int sportID;
        public int countryID;
        public int leagueID;
        
    }
}