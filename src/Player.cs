using System;
using System.Collections.Generic;

using WarO_CSharp_v2.Strategy;

namespace WarO_CSharp_v2
{
    public class Player
    {
        private readonly string name;
        private readonly IStrategy strategy;
        private PlayerStats playerStats;
        private readonly int maxCard;
        private Hand hand;

        public Player(string name, IStrategy strategy, int maxCard) :
            this(name, strategy, maxCard, new Hand(), new PlayerStats()) {}

        public Player(string name, IStrategy strategy, int maxCard, Hand hand) :
            this(name, strategy, maxCard, hand, new PlayerStats()) {}

        private Player(string name, IStrategy strategy, int maxCard, Hand hand, PlayerStats playerStats) {
            this.name = name;
            this.strategy = strategy;
            this.maxCard = maxCard;
            this.hand = hand;
            this.playerStats = playerStats;
        }

        public void SetHand(Hand hand) {
            this.hand = hand;
        }

        public PlayerStats GetPlayerStats() { return playerStats; }
        public int GetNumGamesWon() { return playerStats.NumGamesWon; }
        public int GetTotal() { return playerStats.Total; }
        public String GetName() { return name; }

        public Bid GetBid(int prizeCard) {
            int offer = strategy.SelectCard(prizeCard, hand.GetCards(), maxCard);
            hand = hand.Select(offer);

            Bid bid = new Bid(prizeCard, offer, this);

            return bid;
        }

        public void WinsRound(int prizeCard)
        {
            playerStats = playerStats.WinsRound(prizeCard);
        }

        public void WinsGame()
        {
            playerStats = playerStats.WinsGame();
        }
        public void Reset()
        {
            playerStats = playerStats.Reset();
        }

        public List<int> GetCards()
        {
            return hand.GetCards();
        }

        public override string ToString()
        {
            string result = $"{name} ({strategy.GetName()}) {playerStats.ToString()} hand: {hand.ToString()}";
            return result;
        }
    }
}
