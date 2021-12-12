using System;
using System.Collections.Generic;

namespace TET_BET.Domain
{
    public class AccountDetails
    {
        private int userID;
        private DateTime dateRegistered;
        private double accountBalance;
        private List<Transaction> _userTransactionsList;
        private List<BettingTicket> _userBettingTickets;
    }
}
