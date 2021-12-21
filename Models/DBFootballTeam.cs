using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBFootballTeam
    {
        [Key] public int footballTeamID { get; set; }

        public string footballTeamName { get; set; }
        public string footballTeamStadiumName { get; set; }
        public string footballTeamManagerName { get; set; }

        public int rapidAPIID { get; set; }

        public List<DBFootballPlayer> footballPlayersList { get; set; }

        public DBFootballLeague footballLeague { get; set; }
    }
}