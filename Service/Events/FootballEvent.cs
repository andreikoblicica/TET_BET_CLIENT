using System;
using System.Collections.Generic;
using System.Linq;
using TET_BET.ControllersModels.MainMenuModel;
using TET_BET.Models;
using TET_BET.Repositories;

namespace TET_BET.Service.Events
{
    public class FootballEvent
    {
        private DBFootballEventBetRepository _dbFootballEventBetRepository;

        public FootballEvent()
        {
            _dbFootballEventBetRepository = new DBFootballEventBetRepository();
        }

        public List<MatchInfo> GetMainFootballEventsBet()
        {
            List<DBFootballEventBet> allFootballEventsBets =
                _dbFootballEventBetRepository.GetFootballEventBetsInDateInterval(DateTime.Now,
                    DateTime.Now.AddDays(10)).ToList();

            List<DBFootballEventBet> footballEventsBetsWithMatchWinner = allFootballEventsBets
                .Where(currentEvent => currentEvent.bet.betType.betTypeName == "Match Winner")
                .ToList();

            List<MatchInfo> matchesInfos = new List<MatchInfo>();
            MatchInfo matchInfoToInsert = new MatchInfo();

            footballEventsBetsWithMatchWinner.ForEach(footballEventBets =>
            {
                string team0Name = footballEventBets.footballEvent.footballTeam0.footballTeamName;
                string team1Name = footballEventBets.footballEvent.footballTeam1.footballTeamName;

                MatchInfo foundMatchInfo = matchesInfos.FirstOrDefault(matchInfo =>
                    matchInfo.TeamName0 == team0Name && matchInfo.TeamName1 == team1Name);

                if (foundMatchInfo != null)
                {
                    MatchesListBet matchesListBet = new MatchesListBet();
                    matchesListBet.betName = footballEventBets.bet.betName;
                    matchesListBet.oddValue = footballEventBets.oddValue.ToString();
                    matchesListBet.footballEventBetID = footballEventBets.footballEventBetID.ToString();
                    
                    foundMatchInfo.HomeControllerBets.Add(matchesListBet);
                }
                else
                {
                    matchInfoToInsert = new MatchInfo();
                    matchInfoToInsert.DateTime = footballEventBets.footballEvent.eventt.bettingEventDate;
                    matchInfoToInsert.TeamName0 = team0Name;
                    matchInfoToInsert.TeamName1 = team1Name;

                    MatchesListBet matchesListBet = new MatchesListBet();
                    matchesListBet.betName = footballEventBets.bet.betName;
                    matchesListBet.oddValue = footballEventBets.oddValue.ToString();
                    matchesListBet.footballEventBetID = footballEventBets.footballEventBetID.ToString();
                    
                    matchInfoToInsert.HomeControllerBets.Add(matchesListBet);
                    
                    matchesInfos.Add(matchInfoToInsert);
                }
            });

            return matchesInfos;
        }
    }
}