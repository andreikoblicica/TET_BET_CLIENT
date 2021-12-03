using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TET_BET.Entities.BettingEvents;

namespace TET_BET.Entities
{
    public class BettingTicket
    {
        private int userID;
        private double bettingTicketSum;
        private DateTime bettingTicketDate;
        private List<Bet> _bettingTicketBetsList;
    }
}