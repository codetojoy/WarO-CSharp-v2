using System;
using System.Collections.Generic;
using System.Linq;

namespace WarO_CSharp_v2.Actor
{
    public class Hand
    {
        private readonly List<int> cards;

        public Hand() : this(new List<int>()) {}

        public Hand(List<int> cards)
        {
            this.cards = cards;
        }
        public void Add(int card)
        {
            cards.Add(card);
        }

        public bool Contains(int card)
        {
            return cards.Contains(card);
        }

        public List<int> GetCards() {
            return cards;
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

        public override string ToString()
        {
            string result = "[";

            if (cards.Any()) {
                result += " ";
                foreach (int card in cards) {
                    result += card + " ";
                }
            }

            result += "]";

            return result;
        }
    }
}
