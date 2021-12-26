using TET_BET.Models;

namespace TET_BET.Repositories
{
    public class UserRepository
    {
        private readonly GenericRepositoryActions _genericRepositoryActions;
        private readonly AppDBContext _dbContext;

        public UserRepository()
        {
            _genericRepositoryActions = new GenericRepositoryActions();
            _dbContext = _genericRepositoryActions.GetAppDBContext();
        }
        
        public void InsertNewUser(DBUser dbUser)
        {
            AccountDetailsRepository accountDetailsRepository = new AccountDetailsRepository();
            dbUser.accountDetailsID = accountDetailsRepository.InsertNewAccountAndReturnItsID();

            _dbContext.DBUser.Add(dbUser);
            _dbContext.SaveChanges();
        }
    }
}
