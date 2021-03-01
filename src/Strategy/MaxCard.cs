using System;
using System.Collections.Generic;
using System.Linq;

namespace WarO_CSharp_v2.Strategy
{
    public class MaxCard : IStrategy
    {
        public string GetName() {
            return StrategyConstants.STRATEGY_MAX;
        }
       public int SelectCard(int prizeCard, IList<int> hand, int maxCard) {
           return hand.Max(i => i);
       }
    }
}
