using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    [TestFixture]
    public class Dealer_Tests : Dealer
    {
        [Test]
        public void Deal_Basic()
        {
            var config = new TestConfig();

            // test
            var result = this.Deal(config);

            var cardCounter = new TestCardCounter();
            cardCounter.AddCards(result);
            Assert.IsTrue(cardCounter.Validate(config.GetMaxCard()));
        }

        [Test]
        public void Partition_Basic()
        {
            int numCardsPerHand = 4;
            int numCards = 16;
            var cards = new List<int>();
            var expectedSum = 0;
            var actualSum = 0;
            for (int i = 1; i <= numCards; i++)
            {
                cards.Add(i);
                expectedSum += i;
            }

            // test
            List<Hand> hands = this.Partition(cards, numCardsPerHand);

            foreach (Hand hand in hands)
            {
                foreach (int card in hand.GetCards())
                {
                    actualSum += card;
                }
                Assert.AreEqual(numCardsPerHand, hand.GetCards().Count);
            }

            Assert.AreEqual(actualSum, expectedSum);
        }
    }
}
