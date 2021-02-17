
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

        public override string ToString()
        {
            string result = "Table: \n";
            result += "kitty: " + kitty.ToString() + "\n";
            foreach (Player player in players) {
                result += player.ToString() + "\n";
            }
            return result;
        }
    }
}