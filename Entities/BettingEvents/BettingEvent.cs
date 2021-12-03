using System;
using System.Collections.Generic;

namespace TET_BET.Entities.BettingEvents
{
    public abstract class BettingEvent
    {
        private int _bettingEventID;
        private string _bettingEventLocation;
        private DateTime _bettingEventDate;
        private List<Entities.Bet> _bettingEventBetsList;
        private BettingEventStatus _bettingEventStatus;
    }
}