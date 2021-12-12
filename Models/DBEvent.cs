using System;
using TET_BET.Entities.BettingEvents;

namespace TET_BET.Models
{
    public class DBEvent
    {
        // primary key
        private int _eventID;
        
        // foreign key referencing DBSport
        private int _sportID;
        
        private string _bettingEventLocation;
        private DateTime _bettingEventDate;
        private BettingEventStatus _bettingEventStatus;
    }
}
