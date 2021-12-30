using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TET_BET.Models
{
    public class DBFootballEvent
    {
        [Key] public int footballEventID { get; set; }

        public int eventtID { get; set; }
        public DBEventt eventt { get; set; }

        public int footballTeam0ID { get; set; }
        public DBFootballTeam footballTeam0 { get; set; }

        public int footballTeam1ID { get; set; }
        public DBFootballTeam footballTeam1 { get; set; }

        public DBFootballLeague footballLeague { get; set; }

        public int rapidAPIFixtureID { get; set; }

        public int goalsTeam0FirstHalf { get; set; }
        public int goalsTeam1FirstHalf { get; set; }
        public int goalsTeam0SecondHalf { get; set; }
        public int goalsTeam1SecondHalf { get; set; }
        
        public List<DBBet> bets { get; set; }
    }
}