using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

        public DBAccountDetails GetByID(int ID)
        {
            return _dbContext.DBAccountDetails.Where(account => account.user.userID == ID)
                .Include(account => account.user).ToList()[0];
        }
    }
}