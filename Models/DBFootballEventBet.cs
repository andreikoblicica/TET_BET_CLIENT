using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBFootballEventBet
    {
        [Key] public int footballEventBetID { get; set; }

        public int footballEventID { get; set; }
        public DBFootballEvent footballEvent { get; set; }

        public int betID { get; set; }
        public DBBet bet { get; set; }

        public float oddValue { get; set; }
    }
}