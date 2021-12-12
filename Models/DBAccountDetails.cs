using System;
using System.Collections.Generic;
using TET_BET.Entities;

namespace TET_BET.Models
{
    public class DBAccountDetails
    {
        // foreign key referencing DBUser
        private int userID;
        
        private DateTime dateRegistered;
        private double accountBalance;
    }
}
