using System;
using System.Collections.Generic;
using System.Linq;
using TET_BET.Models;
using TET_BET.Repositories;

namespace TET_BET.Service.Betting
{
    public class BettingWizard
    {
        private DBFootballEventBetRepository _dbFootballEventBetRepository;

        public BettingWizard()
        {
            _dbFootballEventBetRepository = new DBFootballEventBetRepository();
        }

        public DBFootballEventBet GetRecommendedBets(float intendedBettingAmount, float intendedWinAmount)
        {

            float oddValue = intendedWinAmount / intendedBettingAmount;
            List<DBFootballEventBet> footballEventBets = _dbFootballEventBetRepository
                .GetFootballEventBetsInDateInterval(DateTime.Now,
                    DateTime.Now.AddDays(10)).ToList();
            List<DBFootballEventBet> listToReturn = new List<DBFootballEventBet>();
            foreach (var footballEventBet in footballEventBets)
            {
                if (footballEventBet.oddValue > oddValue - 0.5 && footballEventBet.oddValue < oddValue + 0.5)
                {
                    listToReturn.Add(footballEventBet);
                }
            }

            Random random = new Random();
            DBFootballEventBet eventBet = listToReturn[random.Next(listToReturn.Count)];
            return eventBet;
        }

    }
}