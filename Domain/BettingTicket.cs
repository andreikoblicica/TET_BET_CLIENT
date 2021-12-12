using System;
using System.Collections.Generic;

namespace TET_BET.Domain
{
    public class BettingTicket
    {
        private int _bettingTicketID;
        private int _userID;
        private float _bettingTicketSum;
        private DateTime _bettingTicketDate;
        private List<BetEvent> _bettingTicketBetEvents;
    }
}
