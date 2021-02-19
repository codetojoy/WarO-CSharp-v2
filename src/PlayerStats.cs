using System;

namespace WarO_CSharp_v2
{
    public class PlayerStats
    {
        private readonly int total;
        private readonly int numGamesWon;
        private readonly int numRoundsWon;

        public PlayerStats() : this(0,0,0) {}

        private PlayerStats(int total, int numGamesWon, int numRoundsWon) {
            this.total = total;
            this.numGamesWon = numGamesWon;
            this.numRoundsWon = numRoundsWon;
        }

        public int GetTotal() { return total; }
        public int GetNumRoundsWon() { return numRoundsWon; }
        public int GetNumGamesWon() { return numGamesWon; }

        public PlayerStats WinsGame() {
            PlayerStats newPlayerStats = new PlayerStats(this.total, this.numGamesWon + 1, this.numRoundsWon);
            return newPlayerStats;
        }

        public PlayerStats WinsRound(int prizeCard) {
            PlayerStats newPlayerStats = new PlayerStats(this.total + prizeCard, this.numGamesWon, this.numRoundsWon + 1);
            return newPlayerStats;
        }

        public PlayerStats Reset() {
            PlayerStats newPlayerStats = new PlayerStats(0, this.numGamesWon, 0);
            return newPlayerStats;
        }

        public override string ToString()
        {
            string result = $"g: {numGamesWon} :r {numRoundsWon} total: {total}";
            return result;
        }
    }
}