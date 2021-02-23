﻿using System.Threading;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class PathologicalPauseStrategy : NextCard
    {
        public override string GetName() {
            return Constants.STRATEGY_PATHOLOGICAL;
        }
        public override int SelectCard(int prizeCard, List<int> hand, int maxCard) {
            var delayInMillis = 10 * 1000;
            Thread.Sleep(delayInMillis);
            return base.SelectCard(prizeCard, hand, maxCard);
        }
    }
}
