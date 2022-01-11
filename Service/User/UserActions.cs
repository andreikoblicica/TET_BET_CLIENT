using TET_BET.Models;
using TET_BET.Repositories;

namespace TET_BET.Service.User
{
    public class UserActions
    {
        private AccountDetailsRepository _accountDetailsRepository;
        public UserActions()
        {
            _accountDetailsRepository = new AccountDetailsRepository();
        }
        public DBAccountDetails GetAccountByUserID(int userID)
        {
            return _accountDetailsRepository.GetByID(userID);
        }
    }
}