using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBUserBet
    {
        [Key] public int userBetID { get; set; }

        public int eventID { get; set; }
        public DBEvent dbEvent { get; set; }

        public int betID { get; set; }
        public DBBet bet { get; set; }

        public float oddValue { get; set; }
        
        public DBBettingTicket bettingTicket{ get; set; }
    }
}
