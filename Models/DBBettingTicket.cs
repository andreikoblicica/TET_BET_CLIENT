using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBBettingTicket
    {
        [Key] public int bettingTicketID { get; set; }

        public List<DBUserBet> bettingTicketBetsList { get; set; }

        public float bettingTicketSum { get; set; }
        public DateTime bettingTicketDate { get; set; }
        
        public DBAccountDetails accountDetails { get; set; }
        
        public bool isWinner{ get; set; }
        public bool isClosed { get; set; }

        public float CalculateProfit()
        {
            if (isWinner) return (CalculateOdds() - 1) * bettingTicketSum;
            else return 0;
        }
        public float CalculateOdds()
        {
            float odds = 1;
            foreach (DBUserBet bet in bettingTicketBetsList)
            {
                odds *= bet.bet.oddValue;
            }

            return odds;
        }
    }
}
