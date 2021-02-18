using System;
using System.Collections.Generic;
using System.Linq;

namespace WarO_CSharp_v2
{
    public class MinCard : IStrategy
    {
        public string GetName() {
            return "Min Card";
        }
       public int SelectCard(int prizeCard, List<int> hand, int maxCard) {
           return hand.Min(i => i);
       }
    }
}
