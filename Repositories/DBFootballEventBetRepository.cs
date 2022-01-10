using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TET_BET.Models;

namespace TET_BET.Repositories
{
    public class DBFootballEventBetRepository : IBasicCrud
    {
        private readonly GenericRepositoryActions _genericRepositoryActions;
        private readonly AppDBContext _dbContext;

        public DBFootballEventBetRepository()
        {
            _genericRepositoryActions = new GenericRepositoryActions();
            _dbContext = _genericRepositoryActions.GetAppDBContext();
        }

        public List<DBFootballEventBet> GetFootballEventBetsInDateInterval(DateTime lowerBound, DateTime upperBound)
        {
            var footballEventBets = _dbContext.DBFootballEventBet.Where(footballEventBet =>
                    DateTime.Compare(footballEventBet.footballEvent.eventt.bettingEventDate, lowerBound) > 0 &&
                    DateTime.Compare(footballEventBet.footballEvent.eventt.bettingEventDate, upperBound) < 0)
                .Include(footballEventBet => footballEventBet.footballEvent)
                .ThenInclude(footballEvent => footballEvent.footballTeam0)
                .Include(footballEventBet => footballEventBet.footballEvent)
                .ThenInclude(footballEvent => footballEvent.footballTeam1)
                .Include(footballEventBet => footballEventBet.footballEvent)
                .ThenInclude(footballEvent => footballEvent.eventt)
                .Include(footballEventBet => footballEventBet.bet).ThenInclude(bet => bet.betType);

            return footballEventBets.ToList();
        }

        public void Insert(object objectToInsert)
        {
            throw new System.NotImplementedException();
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