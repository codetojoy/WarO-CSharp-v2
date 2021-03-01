using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2.Strategy
{
    public class NextCard : IStrategy
    {
        public virtual string GetName() {
            return StrategyConstants.STRATEGY_NEXT;
        }
        public virtual int SelectCard(int prizeCard, IList<int> hand, int maxCard) {
            return hand[0];
        }
    }
}
