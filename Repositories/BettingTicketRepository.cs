using System;
using System.Configuration;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TET_BET.Models;

namespace TET_BET.Repositories
{
    public class BettingTicketRepository
    {
        private readonly GenericRepositoryActions _genericRepositoryActions;
        private readonly AppDBContext _dbContext;

        public BettingTicketRepository()
        {
            _genericRepositoryActions = new GenericRepositoryActions();
            _dbContext = _genericRepositoryActions.GetAppDBContext();
        }

        public void InsertBettingTicket(DBEventt dbEventt)
        {
            AppDBContext dbContext = _genericRepositoryActions.GetAppDBContext();

            // var dbEvent = new DBEvent()
            // {
            //     sport = new DBSport()
            //     {
            //         sportName = "Football"
            //     },
            //
            //     bettingEventDate = new DateTime(2000, 1, 1),
            //
            //     bettingEventLocation = "King's Park",
            //     
            //     bettingEventStatus = new DBBettingEventStatus()
            //     {
            //         bettingEventStatusMessage = "CANCELED"
            //     }
            // };

            dbContext.DBEventt.Add(dbEventt);

            dbContext.SaveChanges();
        }

        public void update()
        {
            // AppDBContext dbContext = _genericRepositoryActions.GetAppDBContext();
            //
            // // var std = dbContext. DBEvent.First<DBEvent>(); 
            // var std = dbContext.DBEvent.Where((event, i) => )
            // std.bettingEventLocation = "King's Park";
            // dbContext.SaveChanges();
        }
    }
}