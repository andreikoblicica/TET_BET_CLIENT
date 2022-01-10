using System;
using System.Collections.Generic;

namespace TET_BET.ControllersModels.FootballEventBetsModel
{
    public class FootballEventBetsModel
    {
        public string bettingEventLocation;
        public DateTime bettingEventDate;
        public string teamName0;
        public string teamName1;
        public List<BetType> betTypes { get; set; }
    }
}