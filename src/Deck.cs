


using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class Deck
    {
        private static Random rng = new Random();
        private int maxCard;
        private List<int> cards = new List<int>();

        public Deck(int maxCard)
        {
            this.maxCard = maxCard;
            for (int i = 1; i <= maxCard; i++) {
                this.cards.Add(i);
            }
            Shuffle();
        }

        public List<int> GetCards()
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