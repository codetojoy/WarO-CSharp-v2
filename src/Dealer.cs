
using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class Dealer
    {
        public Table Deal(Config config) {
            List<Player> players = config.GetPlayers();
            int maxCard = config.GetMaxCard();
            Hand kitty = new Hand();
            Table table = new Table(players, kitty);
            return table;
        }
    }
}
