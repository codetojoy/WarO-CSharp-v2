using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    [TestFixture]
    public class Dealer_Tests
    {
        [Test]
        public void Partition_Basic()
        {
            var dealer = new Dealer();
            int numCardsPerHand = 4;
            int numCards = 16;
            var cards = new List<int>();
            var expectedSum = 0;
            var actualSum = 0;
            for (int i = 1; i <= numCards; i++) {
                cards.Add(i);
                expectedSum += i;
            }

            // test
            List<Hand> hands = dealer.Partition(cards, numCardsPerHand);

            foreach (Hand hand in hands) {
                foreach (int card in hand.GetCards()) {
                    actualSum += card;
                }
                Assert.AreEqual(numCardsPerHand, hand.GetCards().Count);
            }

            Assert.AreEqual(actualSum, expectedSum);
        }
    }
}
