using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBUserBet
    {
        [Key] public int userBetID { get; set; }

        public int footballEventBetID { get; set; }
        public DBFootballEventBet footballEventBet { get; set; }

        public int bettingTicketID { get; set; }
        public DBBettingTicket bettingTicket { get; set; }
        
        public bool isWinner{ get; set; }
    }
}