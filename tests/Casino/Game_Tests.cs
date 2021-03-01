using NUnit.Framework;
using System;
using System.Collections.Generic;

using WarO_CSharp_v2.Config;
using WarO_CSharp_v2.Actor;

namespace WarO_CSharp_v2.Casino
{
    [TestFixture]
    public class Game_Tests : Game
    {
        [Test]
        public void PlayGame()
        {
            var config = new TestConfig();
            var deck = new TestDeck(TestDeck.CASE_1);
            var dealer = new Dealer();
            var table = dealer.Deal(config, deck);
            var players = table.GetPlayers();
            var isVerbose = false;

            // test
            this.PlayGame(table, isVerbose);

            Assert.AreEqual(0, players[0].GetPlayerStats().NumGamesWon);
            Assert.AreEqual(0, players[1].GetPlayerStats().NumGamesWon);
            Assert.AreEqual(1, players[2].GetPlayerStats().NumGamesWon);

            Assert.AreEqual(1, players[0].GetPlayerStats().NumRoundsWon);
            Assert.AreEqual(1, players[1].GetPlayerStats().NumRoundsWon);
            Assert.AreEqual(1, players[2].GetPlayerStats().NumRoundsWon);

            Assert.AreEqual(1, players[0].GetPlayerStats().Total);
            Assert.AreEqual(5, players[1].GetPlayerStats().Total);
            Assert.AreEqual(9, players[2].GetPlayerStats().Total);
        }

        [Test]
        public void PlayRound_Basic()
        {
            var config = new TestConfig();
            var deck = new TestDeck(TestDeck.CASE_1);
            var dealer = new Dealer();
            var table = dealer.Deal(config, deck);
            var players = table.GetPlayers();
            var prizeCard = table.GetKitty().GetCards()[0];

            // test
            this.PlayRound(prizeCard, players);

            Assert.AreEqual(0, players[0].GetPlayerStats().NumRoundsWon);
            Assert.AreEqual(0, players[1].GetPlayerStats().NumRoundsWon);
            Assert.AreEqual(1, players[2].GetPlayerStats().NumRoundsWon);
            Assert.AreEqual(0, players[0].GetPlayerStats().Total);
            Assert.AreEqual(0, players[1].GetPlayerStats().Total);
            Assert.AreEqual(9, players[2].GetPlayerStats().Total);
        }

        [Test]
        public void DetermineGameWinner_Basic()
        {
            var config = new TestConfig();
            var players = config.GetPlayers();
            players[0].WinsRound(10);
            players[1].WinsRound(12);
            players[2].WinsRound(4);

            // test
            var result = this.DetermineGameWinner(players);

            Assert.AreEqual(Constants.TEST_PLAYER_CHOPIN, result.GetName());
        }

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

            Assert.AreEqual(Constants.TEST_PLAYER_CHOPIN, result.Bidder.GetName());
        }
    }
}
