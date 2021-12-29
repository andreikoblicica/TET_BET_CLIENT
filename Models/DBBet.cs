using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBBet
    {
        [Key] public int betID { get; set; }
        public string betName { get; set; }
        public float oddValue { get; set; }

        public DBBetType betType { get; set; }
    }
}
