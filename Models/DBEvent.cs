using System;
using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBEvent
    {
        [Key] public int eventID { get; set; }

        public int sportID { get; set; }
        public DBSport sport { get; set; }
        
        public DBBettingEventStatus bettingEventStatus { get; set; }

        public string bettingEventLocation { get; set; }
        public DateTime bettingEventDate { get; set; }
    }
}
