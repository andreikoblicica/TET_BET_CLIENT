using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBCountry
    {
        [Key]
        public int countryID { get; set; }
        public string countryName { get; set; }
    }
}
