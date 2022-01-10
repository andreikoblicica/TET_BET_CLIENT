using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TET_BET.Models;

namespace TET_BET.Repositories
{
    public class BettingTicketRepository : IBasicCrud
    {
        private readonly GenericRepositoryActions _genericRepositoryActions;
        private readonly AppDBContext _dbContext;

        public BettingTicketRepository()
        {
            _genericRepositoryActions = new GenericRepositoryActions();
            _dbContext = _genericRepositoryActions.GetAppDBContext();
        }

        public void Insert(object objectToInsert)
        {
            _dbContext.DBEventt.Add((DBEventt) objectToInsert);
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
        
        public List<DBBettingTicket> GetBettingTicketsByAccountDetailsID(int accountDetailsID)
        {
            return _dbContext.DBBettingTicket.Where(e => e.accountDetails.accountDetailsID == accountDetailsID)
                .Include(e => e.bettingTicketBetsList)
                .ThenInclude(e=>e.footballEventBet)
                .ThenInclude(e=>e.bet)
                .ThenInclude(e=>e.betType)
                .Include(e => e.bettingTicketBetsList)
                .ThenInclude(e=>e.footballEventBet)
                .ThenInclude(e=>e.footballEvent)
                .ThenInclude(e=>e.footballTeam0)
                .Include(e => e.bettingTicketBetsList)
                .ThenInclude(e=>e.footballEventBet)
                .ThenInclude(e=>e.footballEvent)
                .ThenInclude(e=>e.footballTeam1)
                .Include(e => e.bettingTicketBetsList)
                .ThenInclude(e=>e.footballEventBet)
                .ThenInclude(e=>e.footballEvent)
                .ThenInclude(e=>e.eventt)
                .ToList();
        }
    }
}