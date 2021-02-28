using NUnit.Framework;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    [TestFixture]
    public class NearestCard_Tests
    {
        private IStrategy strategy;

        [SetUp]
        public void SetUp()
        {
            strategy = new NearestCard();
        }

        [Test]
        public void SelectCard_Basic()
        {
            int prizeCard = 18;
            var hand = new List<int>() {11, 22, 33};
            int maxCard = 40;

            // test
            var result = strategy.SelectCard(prizeCard, hand, maxCard);

            Assert.AreEqual(22, result);
        }

        [Test]
        public void SelectCard_LowBoundary()
        {
            int prizeCard = 1;
            var hand = new List<int>() {2, 27, 38};
            int maxCard = 40;

            // test
            var result = strategy.SelectCard(prizeCard, hand, maxCard);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void SelectCard_HighBoundary()
        {
            int maxCard = 40;
            int prizeCard = maxCard;
            var hand = new List<int>() {10, 20, 39};

            // test
            var result = strategy.SelectCard(prizeCard, hand, maxCard);

            Assert.AreEqual(39, result);
        }
    }
}
