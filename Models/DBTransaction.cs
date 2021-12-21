using System;
using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBTransaction
    {
        [Key] public int transactionID { get; set; }

        public float transactionSum { get; set; }
        public DateTime transactionDate { get; set; }
        
        public DBAccountDetails accountDetails { get; set; }
    }
}
