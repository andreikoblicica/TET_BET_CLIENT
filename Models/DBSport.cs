using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBSport
    {
        [Key] public int sportID { get; set; }
        public string sportName { get; set; }
    }
}
