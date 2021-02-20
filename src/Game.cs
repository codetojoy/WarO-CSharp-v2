using System;
using System.Collections.Generic;
using System.Linq;

namespace WarO_CSharp_v2
{
    public class Game
    {
        public void PlayGame(Table table, bool isVerbose)
        {
            table.ResetPoints();
            var players = table.GetPlayers();
            int roundIndex = 1;
            while (table.HasPrizeCard()) {
                if (isVerbose) {
                    Console.WriteLine("round: " + roundIndex);
                    Console.WriteLine(table.ToString());
                }
                int prizeCard = table.GetPrizeCard();
                PlayRound(prizeCard, players);
                roundIndex++;
            }
            var winner = DetermineGameWinner(players);
            AwardForGame(winner);

            Console.WriteLine($"{winner.GetName()} wins GAME !");
            Console.WriteLine(table.ToString());
        }

        public void PlayRound(int prizeCard, List<Player> players)
        {
            var bids = GetBids(prizeCard, players);
            var winningBid = DetermineRoundWinner(bids);
            AwardForRound(prizeCard, winningBid.GetBidder());
        }

        public void AwardForGame(Player winner)
        {
            winner.WinsGame();
        }

        public void AwardForRound(int prizeCard, Player winner)
        {
            winner.WinsRound(prizeCard);
            string msg = $"{winner.GetName()} wins ROUND prize: {prizeCard}";
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

        public Player DetermineGameWinner(List<Player> players)
        {
            Player winner = null;
            int highestTotal = 0;
            foreach (Player player in players)
            {
                if (player.GetPlayerStats().GetTotal() > highestTotal)
                {
                    highestTotal = player.GetPlayerStats().GetTotal();
                    winner = player;
                }
            }
            return winner;
        }
    }
}
