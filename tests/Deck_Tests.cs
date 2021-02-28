using NUnit.Framework;
using System.Linq;

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

            // confirm all cards accounted for
            var cards = deck.GetCards();
            var cardCounter = new TestCardCounter();
            cardCounter.AddCards(cards.ToList());
            Assert.IsTrue(cardCounter.Validate(maxCard));

            // confirm there was 'shuffling'
            int numMatches = 0;
            int maxNumMatches = maxCard / 4;

            foreach (var i in Enumerable.Range(1, maxCard - 1))
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
