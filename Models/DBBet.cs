namespace TET_BET.Models
{
    public class DBBet
    {
        // primary key
        private int _betID;

        // foreign key referencing DBBetType
        private int _betTypeID;
        
        private string _betName;
    }
}
