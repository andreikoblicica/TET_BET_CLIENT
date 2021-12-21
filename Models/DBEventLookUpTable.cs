using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBEventLookUpTable
    {
        [Key] public int eventLookUpID { get; set; }
        
        public DBFootballEvent footballEvent { get; set; }
    }
}