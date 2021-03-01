
using System.Collections.Generic;

namespace WarO_CSharp_v2.Casino
{
    public class TestDeck : IDeck
    {
        public const int CASE_1 = 1;
        public IList<int> Cards { get; }

        public TestDeck(int whichCase)
        {
            var cards = new List<int>();

            if (whichCase == CASE_1)
            {
                // kitty: 9, 5, 1
                // p1   : 2, 6, 12
                // p2   : 3, 8, 11
                // p3   : 4, 7, 10
                cards = new List<int>() {
                    9, 5, 1,
                    2, 6, 12,
                    3, 8, 11,
                    4, 7, 10
                };
            }
            this.Cards = cards;
        }

        public TestDeck(IList<int> cards)
        {
            this.Cards = cards;
        }
    }
}
