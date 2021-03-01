using System;
using System.Collections.Generic;
using System.Linq;

using WarO_CSharp_v2.Actor;

namespace WarO_CSharp_v2
{
    public class Game
    {
        public void PlayGame(Table table, bool isVerbose)
        {
            table.ResetPoints();
            var players = table.GetPlayers();
            int roundIndex = 1;
            while (table.HasPrizeCard())
            {
                if (isVerbose)
                {
                    Logger.Log("round: " + roundIndex);
                    Logger.Log(table.ToString());
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

        protected void PlayRound(int prizeCard, IList<Player> players)
        {
            var bids = GetBids(prizeCard, players);
            var winningBid = DetermineRoundWinner(bids);
            AwardForRound(winningBid);
        }

        private void AwardForGame(Player winner)
        {
            winner.WinsGame();
        }

        private void AwardForRound(Bid winningBid)
        {
            int prizeCard = winningBid.PrizeCard;
            Player winner = winningBid.Bidder;
            winner.WinsRound(prizeCard);
            string msg = $"{winner.GetName()} wins ROUND prize: {prizeCard}";
            Console.WriteLine(msg);
        }

        protected IList<Bid> GetBids(int prizeCard, IList<Player> players)
        {
            var bids = players.Select(player => player.GetBid(prizeCard)).ToList();
            return bids;
        }

        protected Bid DetermineRoundWinner(IList<Bid> bids)
        {
            Bid winningBid = bids.OrderBy(bid => bid.Offer).Last();
            return winningBid;
        }

        protected Player DetermineGameWinner(IList<Player> players)
        {
            Player winner = players.OrderBy(player => player.GetPlayerStats().Total).Last();
            return winner;
        }
    }
}
