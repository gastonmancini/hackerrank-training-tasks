using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Sorting;

namespace Tests.Sorting
{
    [TestClass]
    public class Quicksort1PartitionTest
    {
        private Quicksort1Partition _quicksort1Partition;

        [TestInitialize]
        public void Initialize()
        {
            _quicksort1Partition = new Quicksort1Partition();
        }

        #region Example Tests

        [TestMethod]
        public void Quicksort1Partition_Example_Test_1()
        {
            var arr = new [] { 4, 5, 3, 7, 2 };

            var expectedResult = new[] { 3, 2, 4, 5, 7 };

            var result = _quicksort1Partition.solution(arr);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
