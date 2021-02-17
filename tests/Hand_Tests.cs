using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    [TestFixture]
    public class Hand_Tests
    {
        private Hand hand;

        [SetUp]
        public void SetUp()
        {
            List<int> cards = new List<int>();
            cards.Add(10);
            cards.Add(20);
            cards.Add(30);
            hand = new Hand(cards);
        }

        [Test]
        public void Select_Basic()
        {
            var card = 20;

            // test
            var result = hand.Select(card);

            Assert.False(Object.ReferenceEquals(result, hand));
            Assert.False(result.Contains(card));
        }

        [Test]
        public void Select_Illegal()
        {
            var card = 5150;
            // test
            var ex = Assert.Throws<ArgumentException>(() => hand.Select(card));

            Assert.That(ex.Message, Is.EqualTo("illegal selection (Parameter 'card')"));
        }
    }
}
