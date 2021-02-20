using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    [TestFixture]
    public class Deck_Tests
    {
        [Test]
        public void Shuffle_Basic()
        {
            int maxCard = 30;

            // test
            Deck deck = new Deck(maxCard);

            var cards = deck.GetCards();
            var cardCounter = new TestCardCounter();
            cardCounter.AddCards(cards);
            Assert.IsTrue(cardCounter.Validate(maxCard));

            int numMatches = 0;
            int maxNumMatches = maxCard / 4;

            for (int i = 0; i < maxCard; i++)
            {
                int originalValue = i+1;
                if (cards[i] == originalValue)
                {
                    numMatches++;
                }
            }

            Assert.Less(numMatches, maxNumMatches);
        }
    }
}
