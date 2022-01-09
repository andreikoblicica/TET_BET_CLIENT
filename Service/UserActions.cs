using TET_BET.Models;
using TET_BET.Repositories;

namespace TET_BET.Service
{
    public class UserActions : IBasicCrud
    {
        public void CreateUser(DBUser dbUser)
        {
            AccountDetailsRepository accountDetailsRepository = new AccountDetailsRepository();
            dbUser.accountDetailsID = accountDetailsRepository.InsertNewAccountAndReturnItsID();
            
            UserRepository userRepository = new UserRepository();
            userRepository.InsertUser(dbUser);
        }
        
        public void UpdateUser()
        public void insert(object objectToInsert)
        {
            throw new System.NotImplementedException();
        }
    }
}