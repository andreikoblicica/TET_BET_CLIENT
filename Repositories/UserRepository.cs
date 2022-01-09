using System;
using System.Collections.Generic;
using System.Linq;
using TET_BET.Models;

namespace TET_BET.Repositories
{
    public class UserRepository : IBasicCrud
    {
        private readonly GenericRepositoryActions _genericRepositoryActions;
        private readonly AppDBContext _dbContext;

        public UserRepository()
        {
            _genericRepositoryActions = new GenericRepositoryActions();
            _dbContext = _genericRepositoryActions.GetAppDBContext();
        }

        public DBUser GetUserIfExists(DBUser user)
        {
            var selectedUsers = _dbContext.DBUser.Where(dbUser =>
                dbUser.userEmail == user.userEmail && dbUser.userPassword == user.userPassword);

            return selectedUsers.ToList()[0];
        }

        public void Insert(object objectToInsert)
        {
            DBUser dbUser = (DBUser) objectToInsert;
            _dbContext.DBUser.Add(dbUser);
            _dbContext.SaveChanges();
        }

        public List<object> SelectAll()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(object objectToDelete)
        {
            throw new System.NotImplementedException();
        }

        public void Update(object objectToUpdate)
        {
            throw new System.NotImplementedException();
        }
    }
}