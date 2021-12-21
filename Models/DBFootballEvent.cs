using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TET_BET.Models
{
    public class DBFootballEvent
    {
        [Key] public int footballEventID { get; set; }

        public DBFootballTeam footballTeam0 { get; set; }
        public DBFootballTeam footballTeam1 { get; set; }

        public DBFootballLeague footballLeague { get; set; }

        // public int goalsTeam0 { get; set; }
        // public int goalsTeam1 { get; set; }

        // // aici ar fi util sa adaug o tabela noua de tipul football event details (pe care o leg de un DBFootballEvent),
        // // in care sa stochez
        // // goluri in fiecare repriza, event-uri la minut -> cornere, cartonase, injuries, marcatori, etc
    }
}