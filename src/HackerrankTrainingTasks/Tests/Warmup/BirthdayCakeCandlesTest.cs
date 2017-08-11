using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Warmup;

namespace Tests.Warmup
{
    [TestClass]
    public class BirthdayCakeCandlesTest
    {
        private BirthdayCakeCandles _birthdayCakeCandles;

        [TestInitialize]
        public void Initialize()
        {
            _birthdayCakeCandles = new BirthdayCakeCandles();
        }

        [TestMethod]
        public void BirthdayCakeCandles_Example_Test()
        {
            var result = _birthdayCakeCandles.solution(4, new[] {3, 2, 1, 3});

            Assert.AreEqual(2, result);
        }
    }
}
