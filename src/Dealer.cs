
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

            var cards = deck.Cards;
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

        protected IList<Hand> Partition(IEnumerable<int> cards, int n)
        {
            var query = cards
                            .Select((x, i) => new { x, i })
                            .GroupBy(i => i.i / n, x => x.x)
                            .Select(g => g.ToList())
                            .ToList();
            var hands = new List<Hand>();
            foreach (var list in query)
            {
                var hand  = new Hand(list);
                hands.Add(hand);
            }

            return hands;
        }
    }
}
