using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class NextCard : IStrategy
    {
        public string GetName() {
            return "next";
        }
        public int SelectCard(int prizeCard, List<int> hand, int maxCard) {
            return hand[0];
        }
    }
}
