
using System.Collections.Generic;

namespace WarO_CSharp_v2.Config
{
    public interface IConfig
    {
        bool IsVerbose();
        int GetNumCardsPerHand();
        int GetMaxCard();
        IList<Player> GetPlayers();
    }
}
