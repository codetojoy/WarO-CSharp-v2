using NUnit.Framework;

namespace WarO_CSharp_v2
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

            Assert.AreEqual(1, result.GetNumGamesWon());
        }

        [Test]
        public void WinsRound_Basic()
        {
            var prizeCard = 18;

            // test
            var result = playerStats.WinsRound(prizeCard);

            Assert.AreEqual(1, result.GetNumRoundsWon());
            Assert.AreEqual(prizeCard, result.GetTotal());
        }

        [Test]
        public void Reset_Basic()
        {
            var prizeCard = 18;
            playerStats = playerStats.WinsRound(prizeCard);
            playerStats = playerStats.WinsGame();

            // test
            var result = playerStats.Reset();

            Assert.AreEqual(1, result.GetNumGamesWon());
            Assert.AreEqual(0, result.GetNumRoundsWon());
            Assert.AreEqual(0, result.GetTotal());
        }
    }
}
