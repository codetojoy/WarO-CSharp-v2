using NUnit.Framework;

namespace WarO_CSharp_v2.Actor
{
    [TestFixture]
    public class PlayerStats_Tests
    {
        private PlayerStats playerStats;

        [SetUp]
        public void SetUp()
        {
            playerStats = new PlayerStats();
        }

        [Test]
        public void WinsGame_Basic()
        {
            // test
            var result = playerStats.WinsGame();

            Assert.AreEqual(1, result.NumGamesWon);
        }

        [Test]
        public void WinsRound_Basic()
        {
            var prizeCard = 18;

            // test
            var result = playerStats.WinsRound(prizeCard);

            Assert.AreEqual(1, result.NumRoundsWon);
            Assert.AreEqual(prizeCard, result.Total);
        }

        [Test]
        public void Reset_Basic()
        {
            var prizeCard = 18;
            playerStats = playerStats.WinsRound(prizeCard);
            playerStats = playerStats.WinsGame();

            // test
            var result = playerStats.Reset();

            Assert.AreEqual(1, result.NumGamesWon);
            Assert.AreEqual(0, result.NumRoundsWon);
            Assert.AreEqual(0, result.Total);
        }
    }
}
