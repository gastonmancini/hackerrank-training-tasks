using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Sorting;

namespace Tests.Sorting
{
    [TestClass]
    public class CorrectnessAndTheLoopInvariantTest
    {
        private CorrectnessAndTheLoopInvariant _correctnessAndTheLoopInvariant;

        [TestInitialize]
        public void Initialize()
        {
            _correctnessAndTheLoopInvariant = new CorrectnessAndTheLoopInvariant();
        }

        #region Example Tests

        [TestMethod]
        public void CorrectnessAndTheLoopInvariant_Example_Test_1()
        {
            var arr = new [] { 1, 4, 3, 5, 6, 2 };

            var expectedResult = new[] { 1, 2, 3, 4, 5, 6 };

            var result = _correctnessAndTheLoopInvariant.solution(arr);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CorrectnessAndTheLoopInvariant_Example_Test_2()
        {
            var arr = new[] { 4, 3, 2, 1};

            var expectedResult = new[] { 1, 2, 3, 4 };

            var result = _correctnessAndTheLoopInvariant.solution(arr);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
