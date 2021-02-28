using NUnit.Framework;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    [TestFixture]
    public class MinCard_Tests
    {
        private IStrategy strategy;

        [SetUp]
        public void SetUp()
        {
            strategy = new MinCard();
        }

        [Test]
        public void SelectCard_Basic()
        {
            int prizeCard = 18;
            var hand = new List<int>() {33, 11, 22};
            int maxCard = 40;

            // test
            var result = strategy.SelectCard(prizeCard, hand, maxCard);

            Assert.AreEqual(11, result);
        }
    }
}
