using System;
using System.Collections.Generic;

namespace TET_BET.ControllersModels.MainMenuModel
{
    public class MatchInfo
    {
        public DateTime _dateTime;
        public string _teamName0;
        public string _teamName1;

        public List<(string, string)> _betNameBetValueTuples = new List<(string, string)>();
    }
}