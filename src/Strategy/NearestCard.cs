using System;
using System.Collections.Generic;
using System.Linq;

namespace WarO_CSharp_v2.Strategy
{
    public class NearestCard : IStrategy
    {
        public string GetName() {
            return StrategyConstants.STRATEGY_NEAREST;
        }
        public int SelectCard(int prizeCard, IList<int> hand, int maxCard) {
            return hand.Aggregate(maxCard * 10, (acc, card) => Math.Abs(card - prizeCard) < Math.Abs(acc - prizeCard) ? card : acc);
        }
    }
}
