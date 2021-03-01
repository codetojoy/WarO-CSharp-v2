
using System.Collections.Generic;

using WarO_CSharp_v2.Actor;

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
