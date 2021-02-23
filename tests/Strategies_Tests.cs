using NUnit.Framework;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    [TestFixture]
    public class Strategies_Tests
    {
        Strategies strategies = new Strategies();

        [Test]
        public void GetStrategy_Max()
        {
            // test
            var result = strategies.GetStrategy("max");

            Assert.AreEqual(Constants.STRATEGY_MAX, result.GetName());
        }
    }
}
