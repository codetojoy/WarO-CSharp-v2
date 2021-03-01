using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2.Strategy
{
    public interface IStrategy
    {
        string GetName();
        int SelectCard(int prizeCard, IList<int> hand, int maxCard);
    }
}
