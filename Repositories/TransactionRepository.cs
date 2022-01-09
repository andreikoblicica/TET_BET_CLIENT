using System.Collections.Generic;
using TET_BET.Models;

namespace TET_BET.Repositories
{
    public class TransactionRepository : IBasicCrud
    {
        private readonly GenericRepositoryActions _genericRepositoryActions;
        private readonly AppDBContext _dbContext;

        public TransactionRepository()
        {
            _genericRepositoryActions = new GenericRepositoryActions();
            _dbContext = _genericRepositoryActions.GetAppDBContext();
        }

        public void Insert(object objectToInsert)
        {
            _dbContext.DBTransaction.Add((DBTransaction) objectToInsert);
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