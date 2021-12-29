using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBUserBet
    {
        [Key] public int userBetID { get; set; }
        
        public int footballEventID { get; set; }
        public DBFootballEvent footballEvent { get; set; }

        public int betID { get; set; }
        public DBBet bet { get; set; }

        public float oddValue { get; set; }

        public int bettingTicketID { get; set; }
        public DBBettingTicket bettingTicket { get; set; }
        
        public bool isWinner{ get; set; }
    }
}