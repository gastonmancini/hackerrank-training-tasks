using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Sorting;

namespace Tests.Sorting
{
    [TestClass]
    public class RunningTimeOfAlgorithmsTest
    {
        private RunningTimeOfAlgorithms _runningTimeOfAlgorithms;

        [TestInitialize]
        public void Initialize()
        {
            _runningTimeOfAlgorithms = new RunningTimeOfAlgorithms();
        }

        #region Example Tests

        [TestMethod]
        public void RunningTimeOfAlgorithms_Example_Test_1()
        {
            var arr = new [] { 2, 1, 3, 1, 2 };

            var expectedResult = 4;

            var result = _runningTimeOfAlgorithms.solution(arr);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void RunningTimeOfAlgorithms_Example_Test_2()
        {
            var arr = new[] { 1, 1, 2, 2, 3, 3, 5, 5, 7, 7, 9, 9 };

            var expectedResult = 0;

            var result = _runningTimeOfAlgorithms.solution(arr);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void RunningTimeOfAlgorithms_Example_Test_3()
        {
            var arr = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            var expectedResult = 45;

            var result = _runningTimeOfAlgorithms.solution(arr);

            Assert.AreEqual(expectedResult, result);
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
