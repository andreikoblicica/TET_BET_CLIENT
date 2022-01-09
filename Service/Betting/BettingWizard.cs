using System.Collections.Generic;
using TET_BET.Models;

namespace TET_BET.Service.Betting
{
    public class BettingWizard
    {
        public List<DBFootballEvent> GetRecommendedBets(float intendedBettingAmount, float intendedWinAmount)
        {
            // TODO
            // pe baza la cat ii de parior/conservator user-ul, alege-i o lista de pariuri mai mult sau mai putin sigure
            // trebuie luat in considerare cat vrea sa parieze, castig asteptat
            // (practic, cu cat vrea sa castige mai mult, cotele inmultite trebuie sa se aropie de cat zice el)
            return null;
        }

        // poti crea cate functii vrei tu in clasa asta, toate se ocupa de recomandat de pariuri
    }
}