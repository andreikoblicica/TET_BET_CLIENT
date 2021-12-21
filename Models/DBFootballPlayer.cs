using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBFootballPlayer
    {
        [Key] public int footballPlayerID { get; set; }
        public string footballPlayerName { get; set; }

        public int countryID { get; set; }
        public DBCountry country { get; set; }

        public DBFootballTeam footballTeam { get; set; }
    }
}