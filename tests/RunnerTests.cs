using NUnit.Framework;

using WarO_CSharp_v2;

namespace WarO_CSharp_v2
{
    public class RunnerTests
    {
        [Test]
        public void Test_CanaryRepeat()
        {
            Runner runner = new Runner();
            // test
            string result = runner.CanaryRepeat("abc", 3);
            TestContext.Progress.WriteLine("TRACER: result: " + result);

            Assert.AreEqual("abcabcabc", result);
        }
    }
}
