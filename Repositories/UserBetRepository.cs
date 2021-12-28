// using System.Collections.Generic;
// using System.Linq;
// using TET_BET.Models;
//
// namespace TET_BET.Repositories
// {
//     public class UserBetRepository
//     {
//         private readonly GenericRepositoryActions _genericRepositoryActions;
//         private readonly AppDBContext _dbContext;
//
//         public UserBetRepository()
//         {
//             _genericRepositoryActions = new GenericRepositoryActions();
//             _dbContext = _genericRepositoryActions.GetAppDBContext();
//         }
//
//         public List<DBUserBet> GetActiveUserBets()
//         {
//             // // var std = dbContext. DBEvent.First<DBEvent>(); 
//             // var std = dbContext.DBUserBet.Join(dbContext.DBEvent, dbUser => dbUser.eventID, dbEvent => dbEvent.eventID).Join(dbContext.DBBettingEventStatus, dbBettingEventStatus =>  , dbUserBetJoinDBEvent => dbUserBetJoinDBEvent.bettingEventStatus)
//             // std.bettingEventLocation = "King's Park";
//             // dbContext.SaveChanges();
//
//             return (from dbUserBet in _dbContext.DBUserBet
//                 join dbEvent in _dbContext.DBEventt on dbUserBet. equals dbEvent.eventID
//                 join dbBettingEventStatus in _dbContext.DBBettingEventStatus on dbEvent.bettingEventStatusID equals
//                     dbBettingEventStatus.bettingEventStatusID
//                 where dbBettingEventStatus.bettingEventStatusMessage == "ENDED"
//                 select dbUserBet).ToList();
//         }
//     }
// }