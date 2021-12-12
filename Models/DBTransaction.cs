using System;

namespace TET_BET.Models
{
    public class DBTransaction
    {
        // foreign key referencing DBUser
        private int _userID;
        
        private float _transactionSum;
        private DateTime _transactionDate;
    }
}
