using TET_BET.Models;
using TET_BET.Repositories;

namespace TET_BET.Service.User
{
    public class Account
    {
        //private AccountRepository _accountRepository;
        private TransactionRepository _transactionRepository;

        public Account()
        {
            //_accountRepository = new AccountRepository();
        }

        public void WithdrawMoney(DBTransaction dbTransaction)
        {
            _transactionRepository.Insert(dbTransaction);
        }

        public void DepositMoney(DBTransaction dbTransaction)
        {
            _transactionRepository.Insert(dbTransaction);
        }
        
    }
}