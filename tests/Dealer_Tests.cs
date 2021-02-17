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
            for (int i = 1; i <= numCards; i++) {
                cards.Add(i);
            }

            // test
            List<Hand> hands = dealer.Partition(cards, numCardsPerHand);

            foreach (Hand hand in hands) {
                Assert.AreEqual(numCardsPerHand, hand.GetCards().Count);
            }
        }
    }
}
