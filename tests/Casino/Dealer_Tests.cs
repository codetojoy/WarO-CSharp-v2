using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

using WarO_CSharp_v2.Actor;
using WarO_CSharp_v2.Config;

namespace WarO_CSharp_v2.Casino
{
    [TestFixture]
    public class Dealer_Tests : Dealer
    {
        [Test]
        public void Deal_Basic()
        {
            var config = new TestConfig();
            var deck = new Deck(config.GetMaxCard());

            // test
            var result = this.Deal(config, deck);

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

            foreach (var i in Enumerable.Range(1, numCards))
            {
                cards.Add(i);
                expectedSum += i;
            }

            // test
            IList<Hand> hands = this.Partition(cards, numCardsPerHand);

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
