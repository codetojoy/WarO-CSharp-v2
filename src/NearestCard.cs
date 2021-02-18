using System;
using System.Collections.Generic;
using System.Linq;

namespace WarO_CSharp_v2
{
    public class NearestCard : IStrategy
    {
        public string GetName() {
            return "nearest";
        }
        public int SelectCard(int prizeCard, List<int> hand, int maxCard) {
            return hand.Aggregate(maxCard * 10, (acc, card) => Math.Abs(card - prizeCard) < Math.Abs(acc - prizeCard) ? card : acc);
        }
    }
}
