using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBUser
    {
        // primary key
        [Key] public int userID { get; set; }

        public string userEmail { get; set; }
        public string userPassword { get; set; }
    }
}
