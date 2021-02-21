using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    [TestFixture]
    public class Game_Tests : Game
    {
        [Test]
        public void DetermineRoundWinner_Basic()
        {
            int prizeCard = 10;
            var config = new TestConfig();
            var players = config.GetPlayers();
            var bids = new List<Bid>();
            bids.Add(new Bid(prizeCard, 1, players[0]));
            bids.Add(new Bid(prizeCard, 3, players[1]));
            bids.Add(new Bid(prizeCard, 2, players[2]));

            // test
            var result = this.DetermineRoundWinner(bids);

            Assert.AreEqual(Constants.TEST_PLAYER_CHOPIN, result.GetBidder().GetName());
        }
    }
}
