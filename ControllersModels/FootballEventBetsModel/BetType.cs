using System.Collections.Generic;

namespace TET_BET.ControllersModels.FootballEventBetsModel
{
    public struct FootballEventBetsControllerBet
    {
        public string betName;
        public string oddValue;
        public string footballEventBetID;
    }
    public class BetType
    {
        public string betTypeName;
        public List<FootballEventBetsControllerBet> _betNameBetValueTuples = new List<FootballEventBetsControllerBet>();
    }
}