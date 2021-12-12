using System;


namespace TET_BET.Models
{
    public class DBBettingTicket
    {
        // !!! a betting ticket cannot belong to more than 1 user
        
        // primary key
        private int _bettingTicketID;
        
        // foreign key referencing DBEvent
        private int _userID;
        
        private float _bettingTicketSum;
        private DateTime _bettingTicketDate;
    }
}
