
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    public class Table
    {
        private List<Player> players;
        private Hand kitty;

        public Table(List<Player> players, Hand kitty) {
            this.players = players;
            this.kitty = kitty;
        }

        public List<Player> GetPlayers() { return players; }
        public Hand GetKitty() { return kitty; }
    }
}