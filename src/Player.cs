using System;

namespace WarO_CSharp_v2
{
    public class Player
    {
        private readonly string name;
        private readonly IStrategy strategy;
        private readonly PlayerStats playerStats;
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
        public int GetNumGamesWon() { return playerStats.GetNumGamesWon(); }
        public int GetTotal() { return playerStats.GetTotal(); }
        public String GetName() { return name; }

        public override string ToString()
        {
            string result = name + " " + hand.ToString();
            return result;
        }
    }
}

/*
    public Player winsGame() {
        PlayerStats newPlayerStats = playerStats.winsGame();
        Player newPlayer = new Player(name, strategy, maxCard, hand, newPlayerStats);
        return newPlayer;
    }

    public Player winsRound(Bid bid) {
        Hand newHand = hand.select(bid.getOffer());
        PlayerStats newPlayerStats = playerStats.winsRound(bid.getPrizeCard());
        Player newPlayer = new Player(name, strategy, maxCard, newHand, newPlayerStats);
        return newPlayer;
    }

    public Player losesRound(Bid bid) {
        Hand newHand = hand.select(bid.getOffer());
        Player newPlayer = new Player(name, strategy, maxCard, newHand, this.playerStats);
        return newPlayer;
    }

    public Bid getBid(int prizeCard) {
        int offer = strategy.selectCard(prizeCard, hand.cardsAsIntStream(), maxCard);
        // TODO: ensure that offer is contained in hand ! (no cheaters)

        Bid bid = new Bid(prizeCard, offer, this);

        return bid;
    }

    public long getNumCardsInHand() {
        return hand.cardsAsIntStream().boxed().count();
    }

    public Player reset(Hand newHand) {
        PlayerStats newPlayerStats = playerStats.reset();
        Player newPlayer = new Player(name, strategy, maxCard, newHand, newPlayerStats);
        return newPlayer;
    }
}
*/
