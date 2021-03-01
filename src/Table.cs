
using System.Collections.Generic;

using WarO_CSharp_v2.Actor;

namespace WarO_CSharp_v2
{
    public class Table
    {
        private IList<Player> players;
        private Hand kitty;

        public Table(IList<Player> players, Hand kitty) {
            this.players = players;
            this.kitty = kitty;
        }

        public IList<Player> GetPlayers() { return players; }
        public Hand GetKitty() { return kitty; }

        public bool HasPrizeCard() {
            return kitty.GetCards().Count > 0;
        }

        public int GetPrizeCard() {
            int result = kitty.GetCards()[0];
            kitty = kitty.Select(result);
            return result;
        }

        public void ResetPoints()
        {
            foreach (Player p in players)
            {
                p.Reset();
            }
        }

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
