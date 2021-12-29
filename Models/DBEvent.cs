using System;
using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBEventt
    {
        [Key] public int eventtID { get; set; }
        
        public int sportID { get; set; }
        public DBSport sport { get; set; }
        
        public int bettingEventStatusID { get; set; }
        public DBBettingEventStatus bettingEventStatus { get; set; }

        public string bettingEventLocation { get; set; }
        public DateTime bettingEventDate { get; set; }
    }
}
