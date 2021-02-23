using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class NextCard : IStrategy
    {
        public virtual string GetName() {
            return Constants.STRATEGY_NEXT;
        }
        public virtual int SelectCard(int prizeCard, List<int> hand, int maxCard) {
            return hand[0];
        }
    }
}
