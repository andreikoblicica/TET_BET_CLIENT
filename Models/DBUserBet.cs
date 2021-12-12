namespace TET_BET.Models
{
    public class DBUserBet
    {
        // primary key
        private int _userBetID;
        
        // foreign key referencing DBEvent
        private int _eventID;

        // foreign key referencing DBBet
        private int _betID;
    }
}
