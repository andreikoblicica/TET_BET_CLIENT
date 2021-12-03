namespace TET_BET.Entities
{
    public class User
    {
        private int userID;
        private string userName;
        private string userEmail;
        private string userPassword;
        private AccountDetails accountDetails;

        public int UserId
        {
            get => userID;
            set => userID = value;
        }

        public string UserName
        {
            get => userName;
            set => userName = value;
        }

        public string UserEmail
        {
            get => userEmail;
            set => userEmail = value;
        }

        public string UserPassword
        {
            get => userPassword;
            set => userPassword = value;
        }

        public AccountDetails AccountDetails
        {
            get => accountDetails;
            set => accountDetails = value;
        }
    }
}