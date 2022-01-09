using System;
using TET_BET.Models;

namespace TET_BET.Service.User.Exceptions
{
    public class UserDoesNotExistException : Exception
    {
        private string _exceptionMessage;
        private string _userExceptionMessage;

        public UserDoesNotExistException(DBUser dbUser)
        {
            _exceptionMessage = "Invalid user with email " + dbUser.userEmail + " and password " + dbUser.userPassword;
            _userExceptionMessage = "Unsuccessful login";
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