
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class TestConfig : IConfig
    {
        private static bool isVerbose = false;
        private int maxCard = 12;

        public bool IsVerbose()
        {
            return isVerbose;
        }

        public int GetNumCardsPerHand()
        {
            int numPlayers = GetPlayers().Count;
            int numCardsPerHand = maxCard / (numPlayers + 1);
            return numCardsPerHand;
        }

        public int GetMaxCard()
        {
            return maxCard;
        }
        public List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();

            Player p1 = new Player("You", new ConsoleStrategy(), GetMaxCard());
            Player p2 = new Player("Chopin", new NextCard(), GetMaxCard());
            Player p3 = new Player("Mozart", new NextCard(), GetMaxCard());

            players.Add(p1);
            players.Add(p2);
            players.Add(p3);

            return players;
        }
    }
}
