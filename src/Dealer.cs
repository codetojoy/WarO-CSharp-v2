
using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class Dealer
    {
        public Table Deal(Config config) {
            List<Player> players = config.GetPlayers();
            int maxCard = config.GetMaxCard();
            Deck deck = new Deck(maxCard);
            List<int> cards = deck.GetCards();

            Hand kitty = new Hand();
            Table table = new Table(players, kitty);
            return table;
        }

        // TODO: use LINQ ? this is not elegant
        public List<Hand> Partition(List<int> cards, int n)
        {
            var hands = new List<Hand>();
            var counter = 0;
            var hand = new Hand();
            hands.Add(hand);

            for (int i = 0; i < cards.Count; i++) {
                if (counter >= n) {
                    counter = 0;
                    hand = new Hand();
                    hands.Add(hand);
                }
                int card = cards[i];
                hand.Add(cards[i]);
                counter++;
            }

            return hands;
        }
    }
}