
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
        public IList<Player> GetPlayers()
        {

            Player p1 = new Player(Constants.TEST_PLAYER_BRAHMS, new NextCard(), GetMaxCard());
            Player p2 = new Player(Constants.TEST_PLAYER_CHOPIN, new NextCard(), GetMaxCard());
            Player p3 = new Player(Constants.TEST_PLAYER_MOZART, new NextCard(), GetMaxCard());

            var players = new List<Player>() {p1, p2, p3};

            return players;
        }
    }
}
