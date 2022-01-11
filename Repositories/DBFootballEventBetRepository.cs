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
        
        public List<DBFootballEventBet> GetFootballEventBetsWithFilters(int sportID, int countryID, int leagueID)
        {
            DateTime lowerBound = DateTime.Now;
            DateTime upperBound = DateTime.Now.AddDays(10);
            var footballEventBets = _dbContext.DBFootballEventBet.Where(footballEventBet =>
                DateTime.Compare(footballEventBet.footballEvent.eventt.bettingEventDate, lowerBound) > 0 &&
                DateTime.Compare(footballEventBet.footballEvent.eventt.bettingEventDate, upperBound) < 0);
            if (sportID != 0)
            {
                footballEventBets = _dbContext.DBFootballEventBet.Where(e=>e.footballEvent.eventt.sportID==sportID);
            }
            if (countryID != 0)
            {
                footballEventBets =
                    footballEventBets.Where(e => e.footballEvent.footballLeague.country.countryID == countryID);
            }   
            if (leagueID != 0)
            {
                footballEventBets =
                    footballEventBets.Where(e => e.footballEvent.footballLeague.footballLeagueID == leagueID);
            }
            return footballEventBets.Include(footballEventBet => footballEventBet.footballEvent)
                .ThenInclude(footballEvent => footballEvent.footballTeam0)
                .Include(footballEventBet => footballEventBet.footballEvent)
                .ThenInclude(footballEvent => footballEvent.footballTeam1)
                .Include(footballEventBet => footballEventBet.footballEvent)
                .ThenInclude(footballEvent => footballEvent.eventt)
                .Include(footballEventBet => footballEventBet.bet).ThenInclude(bet => bet.betType).ToList();
        }

        public List<DBFootballEventBet> GetFootballEventBetsForEventId(int footballEventId)
        {
            var footballEventBets = _dbContext.DBFootballEventBet.Where(footballEventBet => footballEventBet.footballEventID == footballEventId)
                .Include(footballEventBet => footballEventBet.footballEvent)
                .ThenInclude(footballEvent => footballEvent.footballTeam0)
                .Include(footballEventBet => footballEventBet.footballEvent)
                .ThenInclude(footballEvent => footballEvent.footballTeam1)
                .Include(footballEventBet => footballEventBet.footballEvent)
                .ThenInclude(footballEvent => footballEvent.eventt)
                .Include(footballEventBet => footballEventBet.bet).ThenInclude(bet => bet.betType);
            return footballEventBets.ToList();
        }
        
        public List<IGrouping<string, DBFootballEventBet>> GetFootballEventBetTypesForEventId(int footballEventId)
        {
            var footballEventBetTypes = _dbContext.DBFootballEventBet
                .Where(footballEventBet => footballEventBet.footballEventID == footballEventId)
                .Include(footballEventBet => footballEventBet.bet.betType).ToList().GroupBy(a => a.bet.betType.betTypeName).ToList();

            return footballEventBetTypes;
        }
        
        

        public DBFootballEventBet GetByID(int ID)
        {
            List<DBFootballEventBet> selectedFootballEventBets = _dbContext.DBFootballEventBet
                .Where(footballEventBet => footballEventBet.footballEventBetID == ID)
                .Include(footballEventBet => footballEventBet.footballEvent.footballTeam0)
                .Include(footballEventBet => footballEventBet.footballEvent.footballTeam1)
                .Include(footballEventBet => footballEventBet.bet.betType).ToList();

            return selectedFootballEventBets[0];
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

        public DBFootballEvent GetFootballEventByID(int footballEventId)
        {
            return _dbContext.DBFootballEvent.Where(e => e.footballEventID == footballEventId)
                .Include(e => e.footballTeam0)
                .Include(e => e.footballTeam1)
                .Include(e => e.eventt)
                .ToList().ElementAt(0);
        }
    }
}