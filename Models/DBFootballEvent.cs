namespace TET_BET.Models
{
    public class DBFootballEvent
    {
        // foreign key referencing DBEvent
        private int _eventID;

        private int team0ID;
        private int team1ID;

        private int _goalsTeam0;
        private int _goalsTeam1;
        
        // aici ar fi util sa adaug o tabela noua de tipul football event details (pe care o leg de un DBFootballEvent),
        // in care sa stochez
        // goluri in fiecare repriza, event-uri la minut -> cornere, cartonase, injuries, marcatori, etc
    }
}
