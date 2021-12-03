using System;
using System.Collections.Generic;

namespace TET_BET.Entities
{
    public class AccountDetails
    {
        private int userID;
        private DateTime dateRegistered;
        private List<TET_BET_Transaction> transactionsList;
        private double accountBalance;
        private List<BettingTicket> bettingTickets;
    }
}