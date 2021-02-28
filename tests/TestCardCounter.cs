
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class TestCardCounter
    {
        IList<int> cards = new List<int>();

        protected void AddCards(Hand hand) {
            AddCards(hand.GetCards());
        }

        public void AddCards(Table table) {
            AddCards(table.GetKitty().GetCards());
            AddCards(table.GetPlayers());
        }

        public void AddCards(IList<int> list) {
            foreach (var card in list)
            {
                this.cards.Add(card);
            }
        }
        protected void AddCards(IList<Player> players) {
            foreach (Player player in players)
            {
                AddCards(player.GetCards());
            }
        }
        public bool Validate(int maxCard)
        {
            int expectedSum = (maxCard * (maxCard + 1)) / 2;
            // TODO: use LINQ ?
            int actualSum = 0;
            foreach (int c in cards) {
                actualSum += c;
            }
            bool result = (actualSum == expectedSum);
            return result;
        }
    }
}
