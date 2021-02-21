
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class TestDeck : IDeck
    {
        public const int CASE_1 = 1;
        private List<int> cards = new List<int>();

        public TestDeck(int whichCase)
        {
            var cards = new List<int>();

            if (whichCase == CASE_1)
            {
                // kitty: 9, 5, 1
                // p1   : 2, 6, 12
                // p2   : 3, 8, 11
                // p3   : 4, 7, 10
                cards.Add(9);
                cards.Add(5);
                cards.Add(1);
                cards.Add(2);
                cards.Add(6);
                cards.Add(12);
                cards.Add(3);
                cards.Add(8);
                cards.Add(11);
                cards.Add(4);
                cards.Add(7);
                cards.Add(10);
            }
            this.cards = cards;
        }

        public TestDeck(List<int> cards)
        {
            this.cards = cards;
        }

        public List<int> GetCards()
        {
            return cards;
        }
    }
}
