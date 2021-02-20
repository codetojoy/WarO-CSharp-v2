using System;

namespace WarO_CSharp_v2
{
    public class Bid
    {
        private readonly int prizeCard;
        private readonly int offer;
        private readonly Player bidder;

        public Bid(int prizeCard, int offer, Player bidder)
        {
            this.prizeCard = prizeCard;
            this.offer = offer;
            this.bidder = bidder;
        }

        public int GetPrizeCard() { return prizeCard; }
        public int GetOffer() { return offer; }
        public Player GetBidder() { return bidder; }
    }
}
