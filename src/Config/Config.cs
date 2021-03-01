
using System;
using System.Collections.Generic;

using WarO_CSharp_v2.Strategy;

namespace WarO_CSharp_v2.Config
{
    public class Config : IConfig
    {
        private static bool isVerbose = true;
        private int maxCard = 16;

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
        public IList<Player> GetPlayers()
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

        public override string ToString()
        {
            string result = "\n";
            result += "maxCard: " + maxCard + "\n";
            foreach (Player player in GetPlayers()) {
                result += player.ToString() + "\n";
            }
            return result;
        }
    }
}
