using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
 
namespace TET_BET.Models
{
    public class DBBetType
    {
        [Key] public int betTypeID { get; set; }
        
        public DBSport sport { get; set; }
        
        public List<DBBet> betsList { get; set; }

        public string betTypeName { get; set; }
    }
}
