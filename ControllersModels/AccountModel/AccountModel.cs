using System.Collections.Generic;

namespace TET_BET.ControllersModels.AccountModel
{
    public class AccountModel
    {
        public string accountBalance;
        public List<Transaction> transactionsList { get; set; }
        public List<BettingTicket> bettingTicketsList { get; set; }
    }
}