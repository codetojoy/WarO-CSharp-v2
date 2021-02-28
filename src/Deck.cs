
using System;
using System.Collections.Generic;
using System.Linq;

namespace WarO_CSharp_v2
{
    public class Deck : IDeck
    {
        private static Random rng = new Random();
        private int maxCard;
        public IList<int> Cards { get; }

        public Deck(int maxCard)
        {
            this.maxCard = maxCard;

            this.Cards = Enumerable.Range(1, maxCard).ToList();

            Shuffle();
        }

        // https://stackoverflow.com/a/1262619/12704
        public void Shuffle()
        {
            for (var n = Cards.Count - 1; n > 1; n--)
            {
                int k = rng.Next(n + 1);
                int value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }
    }
}
