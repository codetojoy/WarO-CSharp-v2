
using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class Config
    {
        private int maxCard = 30;
        public int GetMaxCard() {
            return maxCard;
        }
        public List<Player> GetPlayers() {
            List<Player> players = new List<Player>();

            Player p1 = new Player("Bach", new NextCard(), GetMaxCard());
            Player p2 = new Player("Chopin", new NextCard(), GetMaxCard());
            Player p3 = new Player("Mozart", new NextCard(), GetMaxCard());

            players.Add(p1);
            players.Add(p2);
            players.Add(p3);

            return players;
        }
    }
}