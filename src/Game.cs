using System;
using System.Collections.Generic;
using System.Linq;

namespace WarO_CSharp_v2
{
    public class Game
    {
        public void PlayGame(Table table)
        {
            int roundIndex = 1;
            while (table.HasPrizeCard()) {
                if (Config.IsVerbose()) {
                    Console.WriteLine("round: " + roundIndex);
                    Console.WriteLine(table.ToString());
                }
                int prizeCard = table.GetPrizeCard();
                PlayRound(prizeCard, table.GetPlayers());
                roundIndex++;
            }
        }

        public void PlayRound(int prizeCard, List<Player> players)
        {
            var bids = GetBids(prizeCard, players);
            var winner = DetermineRoundWinner(bids);
            string msg = winner.GetBidder().GetName() + " wins ROUND prize: " + prizeCard;
            Console.WriteLine(msg);
        }

        public List<Bid> GetBids(int prizeCard, List<Player> players)
        {
            var bids = new List<Bid>();

            foreach (Player player in players)
            {
                Bid bid = player.GetBid(prizeCard);
                bids.Add(bid);
            }

            return bids;
        }

        public Bid DetermineRoundWinner(List<Bid> bids)
        {
            Bid winningBid = null;
            int highestBid = 0;
            foreach (Bid bid in bids) {
                if (bid.GetOffer() > highestBid) {
                    winningBid = bid;
                    highestBid = bid.GetOffer();
                }
            }
            return winningBid;
        }

        public void DetermineGameWinner()
        {

        }
    }
}
