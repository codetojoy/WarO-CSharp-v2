using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public interface IStrategy
    {
        string GetName();
        int SelectCard(int prizeCard, List<int> hand, int maxCard);
    }
}
