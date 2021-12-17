using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBFootballEvent
    {
        [Key] public int footballEventID { get; set; }
        //
        // public DBEvent eventt { get; set; }
        //
        // // [ForeignKey("DBFootballTeam")] public int team0ID { get; set; }
        // // public DBFootballTeam dbFootballTeam0 { get; set; }
        // //
        // // [ForeignKey("DBFootballTeam")] public int team1ID { get; set; }
        // // public DBFootballTeam dbFootballTeam1 { get; set; }
        //
        // public int goalsTeam0 { get; set; }
        // public int goalsTeam1 { get; set; }
        //
        // // aici ar fi util sa adaug o tabela noua de tipul football event details (pe care o leg de un DBFootballEvent),
        // // in care sa stochez
        // // goluri in fiecare repriza, event-uri la minut -> cornere, cartonase, injuries, marcatori, etc
    }
}