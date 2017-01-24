using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Sorting;

namespace Tests.Sorting
{
    [TestClass]
    public class Quicksort2SortingTest
    {
        private Quicksort2Sorting _quicksort2Sorting;

        [TestInitialize]
        public void Initialize()
        {
            _quicksort2Sorting = new Quicksort2Sorting();
        }

        #region Example Tests

        [TestMethod]
        public void Quicksort2Sorting_Example_Test_1()
        {
            var arr = new [] { 4, 5, 3, 7, 2 };

            var expectedResult = new[] { 2, 3, 4, 5, 7 };

            var result = _quicksort2Sorting.solution(arr);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Quicksort2Sorting_Example_Test_2()
        {
            var arr = new[] { 5, 8, 1, 3, 7, 9, 2 };

            var expectedResult = new[] { 1, 2, 3, 5, 7, 8, 9 };

            var result = _quicksort2Sorting.solution(arr);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
