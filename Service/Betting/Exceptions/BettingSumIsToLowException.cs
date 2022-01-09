using System;

namespace TET_BET.Service.Betting.Exceptions
{
    public class BettingSumIsToLowException : Exception
    {
        private string _exceptionMessage;
        private string _userExceptionMessage;

        public BettingSumIsToLowException(float bettingTicketSum, float minimumBettingSum)
        {
            _exceptionMessage = "Minimum betting sum must be greater than " + minimumBettingSum;
            _userExceptionMessage = "Minimum betting sum must be greater than " + minimumBettingSum;
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