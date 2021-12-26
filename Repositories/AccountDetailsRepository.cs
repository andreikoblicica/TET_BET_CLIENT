using System;
using TET_BET.Models;

namespace TET_BET.Repositories
{
    public class AccountDetailsRepository
    {
        private readonly GenericRepositoryActions _genericRepositoryActions;
        private readonly AppDBContext _dbContext;

        public AccountDetailsRepository()
        {
            _genericRepositoryActions = new GenericRepositoryActions();
            _dbContext = _genericRepositoryActions.GetAppDBContext();
        }

        public int InsertNewAccountAndReturnItsID()
        {
            DBAccountDetails dbAccountDetails = new DBAccountDetails()
            {
                dateRegistered = DateTime.Now,
                accountBalance = 0
            };

            _dbContext.DBAccountDetails.Add(dbAccountDetails);
            _dbContext.SaveChanges();

            return dbAccountDetails.accountDetailsID;
        }
    }
}
