using System;
using TET_BET.Models;
using TET_BET.Repositories;
using TET_BET.Service.User.Exceptions;

namespace TET_BET.Service.User
{
    public class Login
    {
        private UserRepository _userRepository;
        private AccountDetailsRepository _accountDetailsRepository;

        public Login()
        {
            _userRepository = new UserRepository();
            _accountDetailsRepository = new AccountDetailsRepository();
        }

        public DBUser SignUpUser(DBUser newUser)
        {
            int accountDetailsID = _accountDetailsRepository.InsertNewAccountAndReturnItsID();
            newUser.accountDetailsID = accountDetailsID;
            _userRepository.Insert(newUser);
            newUser.accountDetails = _accountDetailsRepository.getAccountDetailsByID(accountDetailsID);

            return newUser;
        }


        public DBUser SignInUser(DBUser user)
        {
            DBUser dbUser = _userRepository.GetUserIfExists(user);
            
            if (dbUser == null)
            {
                Console.WriteLine("ceva");
                throw new UserDoesNotExistException(user);
            }
            Console.WriteLine(user.userEmail);

            
            return dbUser;
        }
    }
}