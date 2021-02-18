using System;
using System.Collections.Generic;
using System.Linq;

namespace WarO_CSharp_v2
{
    public class MaxCard : IStrategy
    {
        public string GetName() {
            return "Max Card";
        }
       public int SelectCard(int prizeCard, List<int> hand, int maxCard) {
           return hand.Max(i => i);
       }
    }
}
