using System.Collections.Generic;
using TET_BET.ControllersModels.AccountModel;
using TET_BET.Models;
using TET_BET.Repositories;

namespace TET_BET.Service.User
{
    public class Account
    {
        private AccountDetailsRepository _accountRepository;
        private TransactionRepository _transactionRepository;
        private BettingTicketRepository _bettingTicketRepository;

        public Account()
        {
            _accountRepository = new AccountDetailsRepository();
            _transactionRepository = new TransactionRepository();
            _bettingTicketRepository = new BettingTicketRepository();
        }

        public void WithdrawMoney(DBTransaction dbTransaction)
        {
            _transactionRepository.Insert(dbTransaction);
        }

        public void DepositMoney(DBTransaction dbTransaction)
        {
            _transactionRepository.Insert(dbTransaction);
        }

        public List<BettingTicket> getBettingTicketsByAccountDetailsID(int accountDetailsID)
        {
            List<BettingTicket> bettingTickets = new List<BettingTicket>();
            foreach (var bettingTicket in _bettingTicketRepository.GetBettingTicketsByAccountDetailsID(accountDetailsID))
            {
                List<Bet> bets = new List<Bet>();
                foreach (var bet in bettingTicket.bettingTicketBetsList)
                {
                    bets.Add(new Bet()
                    {
                        betName = bet.footballEventBet.bet.betName,
                        betType = bet.footballEventBet.bet.betType.betTypeName,
                        teamName0 = bet.footballEventBet.footballEvent.footballTeam0.footballTeamName,
                        teamName1 = bet.footballEventBet.footballEvent.footballTeam1.footballTeamName,
                        odds = bet.footballEventBet.oddValue.ToString("0.00")
                    });
                }
                bettingTickets.Add(new BettingTicket()
                {
                    bets=bets,
                    bettingTicketID = bettingTicket.bettingTicketID.ToString(),
                    date=bettingTicket.bettingTicketDate,
                    isClosed = bettingTicket.isClosed,
                    isWinner = bettingTicket.isWinner,
                    sum = bettingTicket.bettingTicketSum.ToString("0.00"),
                    odds = calculateTotalTicketOdds(bettingTicket.bettingTicketBetsList).ToString("0.00"),
                    profit = calculateProfit(bettingTicket).ToString("0.00")
                });
            }
            return bettingTickets;
        }
        public List<Transaction> getTransactionsByAccountDetailsID(int accountDetailsID)
        {
            List<Transaction> transactions = new List<Transaction>();
            foreach (var transaction in _transactionRepository.GetTransactionsByAccountDetailsID(accountDetailsID))
            {
                transactions.Add(new Transaction()
                {
                    date=transaction.transactionDate,
                    sum=transaction.transactionSum
                });
            }
            return transactions;
        }

        public float calculateTotalTicketOdds(List<DBUserBet> bets)
        {
            float odds = 1;
            foreach (var bet in bets)
            {
                odds *= bet.footballEventBet.oddValue;
            }

            return odds;
        }

        public float calculateProfit(DBBettingTicket ticket)
        {
            float profit = 0;
            if (ticket.isWinner)
            {
                profit = (calculateTotalTicketOdds(ticket.bettingTicketBetsList) - 1) * ticket.bettingTicketSum;
            }

            return profit;
        }

        public string getBalanceByAccountDetailsID(int accountDetailsID)
        {
            return _accountRepository.getBalanceByAccountDetailsID(accountDetailsID).ToString("0.00");
        }
        
        
    }
}