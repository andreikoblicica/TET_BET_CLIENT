namespace TET_BET.Models
{
    public class DBBetType
    {
        // primary key
        private int _betTypeID;
        
        // foreign key referencing DBSport
        private int _sportID;
        
        private string _betTypeName;
    }
}
