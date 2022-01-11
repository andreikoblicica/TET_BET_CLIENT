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
        public int accountDetailsID  { get; set; }
        public bool isWinner{ get; set; }
        public bool isClosed { get; set; }
    }
}
