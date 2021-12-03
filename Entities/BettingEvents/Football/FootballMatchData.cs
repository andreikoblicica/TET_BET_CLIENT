using System.Collections.Generic;

namespace TET_BET.Entities.BettingEvents
{
    public class FootballMatchData
    {
        private int _goalsTeam0FirstHalf;
        private int _goalsTeam0SecondHalf;
        
        private int _goalsTeam1FirstHalf;
        private int _goalsTeam1SecondHalf;

        private List<FootballGameEvent> _footballGameEventList;

        public int GetTotalGoalsTeam0()
        {
            return this._goalsTeam0FirstHalf + this._goalsTeam0SecondHalf;
        }
        
        public int GetTotalGoalsTeam1()
        {
            return this._goalsTeam1FirstHalf + this._goalsTeam1SecondHalf;
        }
    }
}