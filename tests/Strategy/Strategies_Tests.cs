using NUnit.Framework;
using System.Collections.Generic;

namespace WarO_CSharp_v2.Strategy
{
    [TestFixture]
    public class Strategies_Tests
    {
        Strategies strategies = new Strategies();

        [TestCase("api", StrategyConstants.STRATEGY_API)]
        [TestCase("console", StrategyConstants.STRATEGY_CONSOLE)]
        [TestCase("max", StrategyConstants.STRATEGY_MAX)]
        [TestCase("min", StrategyConstants.STRATEGY_MIN)]
        [TestCase("nearest", StrategyConstants.STRATEGY_NEAREST)]
        [TestCase("next", StrategyConstants.STRATEGY_NEXT)]
        [TestCase("pathological", StrategyConstants.STRATEGY_PATHOLOGICAL)]
        public void GetStrategy(string actualName, string expectedName)
        {
            // test
            var result = strategies.GetStrategy(actualName);

            Assert.AreEqual(expectedName, result.GetName());
        }
    }
}
