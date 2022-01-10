using System;
using System.Collections.Generic;
using System.Linq;
using TET_BET.ControllersModels.FootballEventBetsModel;
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
                    matchInfo._teamName0 == team0Name && matchInfo._teamName1 == team1Name);

                if (foundMatchInfo != null)
                {
                    foundMatchInfo._betNameBetValueTuples.Add((footballEventBets.bet.betName,
                        footballEventBets.oddValue.ToString()));
                }
                else
                {
                    matchInfoToInsert = new MatchInfo();
                    matchInfoToInsert._dateTime = footballEventBets.footballEvent.eventt.bettingEventDate;
                    matchInfoToInsert._teamName0 = team0Name;
                    matchInfoToInsert._teamName1 = team1Name;
                    matchInfoToInsert._betNameBetValueTuples.Add((footballEventBets.bet.betName,
                        footballEventBets.oddValue.ToString()));

                    matchesInfos.Add(matchInfoToInsert);
                }
            });

            return matchesInfos;
        }

        public List<BetType> GetBetTypes(int footballEventID)
        {
            List<BetType> bets = new List<BetType>();
            List<IGrouping<string, DBFootballEventBet>> betTypes =
                _dbFootballEventBetRepository.GetFootballEventBetTypesForEventId(footballEventID);
            foreach (var bet in betTypes)
            {
                 List<FootballEventBetsControllerBet> betNameBetValueTuples = new List<FootballEventBetsControllerBet>();
                for (int i = 0; i < bet.Count(); i++)
                {
                    betNameBetValueTuples.Add(new FootballEventBetsControllerBet()
                    {
                        betName = bet.ElementAt(i).bet.betName,
                        oddValue = bet.ElementAt(i).oddValue.ToString(),
                        footballEventBetID = bet.ElementAt(i).bet.betID.ToString()
                    });
                }
                bets.Add(new BetType()
                {
                    betTypeName = bet.Key,
                    _betNameBetValueTuples = betNameBetValueTuples
                });
            }

            return bets;
        }

        public DBFootballEvent GetEventByID(int footballEventID)
        {
            return _dbFootballEventBetRepository.GetFootballEventByID(footballEventID);
        }
        
        
        
        
    }
}