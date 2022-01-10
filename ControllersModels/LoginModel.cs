using TET_BET.Models;

namespace TET_BET.ControllersModels
{
    public class LoginModel
    {
        public string email { get; set; }
        public string password { get; set; }

        public bool wrongSignInMessage { get; set; }
        
        public DBUser user { get; set; }
    }
}