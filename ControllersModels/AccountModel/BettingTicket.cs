using System;
using System.Collections.Generic;

namespace TET_BET.ControllersModels.AccountModel
{
    public class BettingTicket
    {
        public string bettingTicketID;
        public DateTime date;
        public string sum;
        public string odds;
        public string profit;
        public bool isWinner;
        public bool isClosed;
        public List<Bet> bets = new List<Bet>();
    }
}