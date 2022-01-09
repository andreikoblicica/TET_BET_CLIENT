using System;

namespace TET_BET.Service.Betting.Exceptions
{
    public class BettingTicketSumExceedsBalanceException : Exception
    {
        private string _exceptionMessage;
        private string _userExceptionMessage;

        public BettingTicketSumExceedsBalanceException(float accountBalance, float bettingTicketSum)
        {
            _exceptionMessage = "Account balance = " + accountBalance + " | betting ticket sum = " + bettingTicketSum;
            _userExceptionMessage = "Account balance is too small to perform this action";
        }

        public string GetExceptionMessage()
        {
            return _exceptionMessage;
        }

        public string GetUserExceptionMessage()
        {
            return _userExceptionMessage;
        }
    }
}