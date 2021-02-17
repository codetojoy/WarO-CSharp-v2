using NUnit.Framework;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    [TestFixture]
    public class NextCard_Tests
    {
        private IStrategy strategy;

        [SetUp]
        public void SetUp()
        {
            strategy = new NextCard();
        }

        [Test]
        public void SelectCard_Basic()
        {
            int prizeCard = 18;
            List<int> hand = new List<int>();
            hand.Add(11);
            hand.Add(22);
            hand.Add(33);
            int maxCard = 40;

            // test
            var result = strategy.SelectCard(prizeCard, hand, maxCard);

            Assert.AreEqual(11, result);
        }
    }
}
