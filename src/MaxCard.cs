using System;
using System.Collections.Generic;
using System.Linq;

namespace WarO_CSharp_v2
{
    public class MaxCard : IStrategy
    {
        public string GetName() {
            return Constants.STRATEGY_MAX;
        }
       public int SelectCard(int prizeCard, IList<int> hand, int maxCard) {
           return hand.Max(i => i);
       }
    }
}
