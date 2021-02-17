using System;
using System.Collections.Generic;
using System.Linq;

namespace WarO_CSharp_v2
{
    public class Hand
    {
        private readonly List<int> cards;

        public Hand() : this(new List<int>()) {}

        public Hand(List<int> cards)
        {
            this.cards = cards;
        }

        public bool Contains(int card)
        {
            return cards.Contains(card);
        }

        public Hand Select(int card)
        {
            Hand newHand = null;

            if (Contains(card))
            {
                var filteredList = from c in cards
                                   where c != card
                                   select c;
                newHand = new Hand(new List<int>(filteredList));
            }
            else
            {
                throw new System.ArgumentException("illegal selection", "card");
            }

            return newHand;
        }
    }
}
