
namespace WarO_CSharp_v2.Actor
{
    public class Bid
    {
        public int PrizeCard { get; }
        public int Offer { get; }
        public Player Bidder { get; }

        public Bid(int prizeCard, int offer, Player bidder)
        {
            this.PrizeCard = prizeCard;
            this.Offer = offer;
            this.Bidder = bidder;
        }
    }
}
