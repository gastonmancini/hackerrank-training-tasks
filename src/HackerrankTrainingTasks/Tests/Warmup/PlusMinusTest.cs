using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Warmup;

namespace Tests.Warmup
{
    [TestClass]
    public class PlusMinusTest
    {
        private PlusMinus _plusMinus;

        [TestInitialize]
        public void Initialize()
        {
            _plusMinus = new PlusMinus();
        }

        #region Example Tests

        [TestMethod]
        public void PlusMinus_Example_Test()
        {
            var arr = new int[6];

            arr[0] = -4;
            arr[1] = 3;
            arr[2] = -9;
            arr[3] = 0;
            arr[4] = 4;
            arr[5] = 1;

            double positiveNumbersFraction;
            double negativeNumbersFraction;
            double zeroNumbersFraction;

            _plusMinus.solution(arr, out positiveNumbersFraction, out negativeNumbersFraction, out zeroNumbersFraction);
            
            Assert.AreEqual((double) 3/6, positiveNumbersFraction);
            Assert.AreEqual((double) 2/6, negativeNumbersFraction);
            Assert.AreEqual((double) 1/6, zeroNumbersFraction);
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
