
using System;
using System.Collections.Generic;
using System.Linq;

namespace WarO_CSharp_v2
{
    public class Dealer
    {
        public Table Deal(IConfig config, IDeck deck)
        {
            var players = config.GetPlayers();
            var maxCard = config.GetMaxCard();
            var numCardsPerHand = config.GetNumCardsPerHand();

            var cards = deck.GetCards();
            var hands = Partition(cards, numCardsPerHand);
            var kitty = hands[0];
            hands.RemoveAt(0);

            foreach (var pair in players.Zip(hands, Tuple.Create))
            {
                var player = pair.Item1;
                var hand = pair.Item2;
                player.SetHand(hand);
            }

            var table = new Table(players, kitty);
            return table;
        }

        // TODO: use LINQ ? this is not elegant
        protected List<Hand> Partition(List<int> cards, int n)
        {
            var hands = new List<Hand>();
            var counter = 0;
            var hand = new Hand();
            hands.Add(hand);

            foreach (var card in cards)
            {
                if (counter >= n) {
                    counter = 0;
                    hand = new Hand();
                    hands.Add(hand);
                }
                hand.Add(card);
                counter++;
            }

            return hands;
        }
    }
}
