using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBAccountDetails
    {
        [Key] public int accountDetailsID { get; set; }

        public DateTime dateRegistered { get; set; }
        public float accountBalance { get; set; }
        
        public List<DBTransaction> transactionsList { get; set; }
        public List<DBBettingTicket> bettingTicketsList { get; set; }
        
        public DBUser user { get; set; }
    }
}
