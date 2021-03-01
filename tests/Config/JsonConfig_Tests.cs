using NUnit.Framework;
using System.IO;
using System.Collections.Generic;

using WarO_CSharp_v2.Config;

namespace WarO_CSharp_v2
{
    [TestFixture]
    public class JsonConfig_Tests
    {
        [Test]
        public void ParseConfig_Basic()
        {
            var config = new JsonConfig();
            var jsonStr = @"{ 'num_cards': 50, 'num_games': 1, 'is_verbose': true, ";
            jsonStr += @"'players': [";
            jsonStr += @"{'name': 'bach', 'strategy_name': 'next'}";
            jsonStr += "]}";
            var textReader = new StringReader(jsonStr);

            // test
            config.ParseConfig(textReader);

            Assert.AreEqual(50, config.GetMaxCard());
            Assert.AreEqual(true, config.IsVerbose());
            Assert.AreEqual(1, config.GetPlayers().Count);
            Assert.AreEqual("bach", config.GetPlayers()[0].GetName());
        }
    }
}
