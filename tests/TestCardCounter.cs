
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class TestCardCounter
    {
        List<int> cards = new List<int>();

        protected void AddCards(Hand hand) {
            AddCards(hand.GetCards());
        }

        public void AddCards(Table table) {
            AddCards(table.GetKitty().GetCards());
            AddCards(table.GetPlayers());
        }

        protected void AddCards(List<int> list) {
            this.cards.AddRange(list);
        }
        protected void AddCards(List<Player> players) {
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
