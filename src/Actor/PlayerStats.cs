using System;

namespace WarO_CSharp_v2.Actor
{
    public class PlayerStats
    {
        public int Total { get; }
        public int NumGamesWon { get; }
        public int NumRoundsWon { get; }

        public PlayerStats() : this(0,0,0) {}

        private PlayerStats(int total, int numGamesWon, int numRoundsWon) {
            this.Total = total;
            this.NumGamesWon = numGamesWon;
            this.NumRoundsWon = numRoundsWon;
        }

        public PlayerStats WinsGame() {
            PlayerStats newPlayerStats = new PlayerStats(this.Total, this.NumGamesWon + 1, this.NumRoundsWon);
            return newPlayerStats;
        }

        public PlayerStats WinsRound(int prizeCard) {
            PlayerStats newPlayerStats = new PlayerStats(this.Total + prizeCard, this.NumGamesWon, this.NumRoundsWon + 1);
            return newPlayerStats;
        }

        public PlayerStats Reset() {
            PlayerStats newPlayerStats = new PlayerStats(0, this.NumGamesWon, 0);
            return newPlayerStats;
        }

        public override string ToString()
        {
            string result = $"g: {NumGamesWon} :r {NumRoundsWon} total: {Total}";
            return result;
        }
    }
}
