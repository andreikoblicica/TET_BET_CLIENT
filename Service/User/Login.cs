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

        public void SignUpUser(DBUser newUser)
        {
            newUser.accountDetailsID = _accountDetailsRepository.InsertNewAccountAndReturnItsID();
            _userRepository.Insert(newUser);
        }


        public DBUser SignInUser(DBUser user)
        {
            DBUser dbUser = _userRepository.GetUserIfExists(user);

            if (dbUser == null)
            {
                throw new UserDoesNotExistException(user);
            }

            return dbUser;
        }
    }
}