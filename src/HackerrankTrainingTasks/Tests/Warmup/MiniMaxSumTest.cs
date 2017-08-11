using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Warmup;

namespace Tests.Warmup
{
    [TestClass]
    public class MiniMaxSumTest
    {
        private MiniMaxSum _miniMaxSum;

        [TestInitialize]
        public void Initialize()
        {
            _miniMaxSum = new MiniMaxSum();
        }

        [TestMethod]
        public void MiniMaxSum_Example_Test()
        {
            var numbers = new[] {1, 2, 3, 4, 5};

            var result = _miniMaxSum.solution(numbers);

            Assert.AreEqual("10 14", result);
        }
    }
}
