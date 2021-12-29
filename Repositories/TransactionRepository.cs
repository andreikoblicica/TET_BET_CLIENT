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

        public void insert(object objectToInsert)
        {
            _dbContext.DBTransaction.Add((DBTransaction) objectToInsert);
            _dbContext.SaveChanges();
        }
    }
}
