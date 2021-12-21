using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBFootballLeague
    {
        [Key] public int footballLeagueID { get; set; }

        public int season { get; set; }
        public string leagueName { get; set; }
        
        public int sportID { get; set; }
        public DBSport sport { get; set; }

        public int countryID { get; set; }
        public DBCountry country { get; set; }

        public int nrTeams { get; set; }
        
        public int rapidAPIID { get; set; }

        public List<DBFootballTeam> footballTeamsList { get; set; }
    }
}