using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBBettingEventStatus
    {
        [Key] public int bettingEventStatusID { get; set; }
        
        public string bettingEventStatusMessage { get; set; }
        
        public string bettingEventStatusDescription { get; set; }
    }
}
