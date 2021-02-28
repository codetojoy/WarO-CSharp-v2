
using System;
using System.Collections.Generic;
using System.Linq;

namespace WarO_CSharp_v2
{
    public class Deck : IDeck
    {
        private static Random rng = new Random();
        private int maxCard;
        private IList<int> cards;

        public Deck(int maxCard)
        {
            this.maxCard = maxCard;

            this.cards = Enumerable.Range(1, maxCard).ToList();

            Shuffle();
        }

        public IList<int> GetCards()
        {
            return cards;
        }

        // https://stackoverflow.com/a/1262619/12704
        public void Shuffle()
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }
    }
}
