using NUnit.Framework;
using System.Collections.Generic;

namespace WarO_CSharp_v2
{
    [TestFixture]
    public class Strategies_Tests
    {
        Strategies strategies = new Strategies();

        [TestCase("api", Constants.STRATEGY_API)]
        [TestCase("console", Constants.STRATEGY_CONSOLE)]
        [TestCase("max", Constants.STRATEGY_MAX)]
        [TestCase("min", Constants.STRATEGY_MIN)]
        [TestCase("nearest", Constants.STRATEGY_NEAREST)]
        [TestCase("next", Constants.STRATEGY_NEXT)]
        [TestCase("pathological", Constants.STRATEGY_PATHOLOGICAL)]
        public void GetStrategy(string actualName, string expectedName)
        {
            // test
            var result = strategies.GetStrategy(actualName);

            Assert.AreEqual(expectedName, result.GetName());
        }
    }
}
