
using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public interface IConfig
    {
        bool IsVerbose();
        int GetNumCardsPerHand();
        int GetMaxCard();
        List<Player> GetPlayers();
    }
}
