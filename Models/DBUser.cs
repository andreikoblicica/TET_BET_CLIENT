using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBUser
    {
        [Key] public int userID { get; set; }

        public string userEmail { get; set; }
        public string userPassword { get; set; }

        public int accountDetailsID { get; set; }
        public DBAccountDetails accountDetails { get; set; }
    }
}
