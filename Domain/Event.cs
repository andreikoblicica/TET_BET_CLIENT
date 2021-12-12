using System;
using TET_BET.Entities.BettingEvents;

namespace TET_BET.Domain
{
    public class Event
    {
        private int _eventID;
        private int _sportID;
        private string _bettingEventLocation;
        private DateTime _bettingEventDate;
        private BettingEventStatus _bettingEventStatus;
    }
}
