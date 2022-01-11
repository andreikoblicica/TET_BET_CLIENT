using System;
using TET_BET.ControllersModels.MainMenuModel;
using TET_BET.Models;
using TET_BET.Repositories;

namespace TET_BET.Service.Betting
{
    public class BetActions
    {
        private DBFootballEventBetRepository _dbFootballEventBetRepository;

        public BetActions()
        {
            _dbFootballEventBetRepository = new DBFootballEventBetRepository();
        }

        public BettingTicketBetModel GetBettingTicketModelByFootballEventBetID(int footballEventBetID)
        {
            DBFootballEventBet dbFootballEventBet = _dbFootballEventBetRepository.GetByID(footballEventBetID);
            BettingTicketBetModel bettingTicketBetModel = new BettingTicketBetModel();
            
            bettingTicketBetModel.Team0Name = dbFootballEventBet.footballEvent.footballTeam0.footballTeamName;
            bettingTicketBetModel.Team1Name = dbFootballEventBet.footballEvent.footballTeam1.footballTeamName;
            bettingTicketBetModel.BetTypeName = dbFootballEventBet.bet.betType.betTypeName;
            bettingTicketBetModel.BetName = dbFootballEventBet.bet.betName;
            bettingTicketBetModel.OddValue = dbFootballEventBet.oddValue.ToString();
            bettingTicketBetModel.FootballEventBetID = dbFootballEventBet.footballEventBetID.ToString();

            return bettingTicketBetModel;
        }

        public DBFootballEventBet GetFootballEventBetByID(int footballEventBetID)
        {
            return _dbFootballEventBetRepository.GetByID(footballEventBetID);
        }
    }
}