using System;
using System.Collections.Generic;
using TET_BET.Models;
using TET_BET.Repositories;
using TET_BET.Service.Betting.Exceptions;

namespace TET_BET.Service.Betting
{
    public class BettingTicketActions
    {
        private BettingTicketRepository _bettingTicketRepository;
        private Dictionary<string, string> _appConfigs;

        public BettingTicketActions(Dictionary<string, string> appConfigs)
        {
            _appConfigs = appConfigs;
            _bettingTicketRepository = new BettingTicketRepository();
        }

        public void CreateBettingTicket(DBBettingTicket bettingTicket)
        {
            float justToMakeItFunctional = 1; // bettingTicket.accountDetails.accountBalance trebuie sa fie
            if (bettingTicket.bettingTicketSum > justToMakeItFunctional)
            {
                throw new BettingTicketSumExceedsBalanceException(bettingTicket.accountDetails.accountBalance,
                    bettingTicket.bettingTicketSum);
            }

            // DECOMENTEAZA
            // float minimumBettingSum = Int64.Parse(_appConfigs["MINIMUM_BETTING_SUM"]);
            //
            // if (bettingTicket.bettingTicketSum < minimumBettingSum)
            // {
            //     throw new BettingSumIsToLowException(bettingTicket.bettingTicketSum, minimumBettingSum);
            // }

            _bettingTicketRepository.Insert(bettingTicket);
        }
    }
}