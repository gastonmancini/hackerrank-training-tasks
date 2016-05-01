using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Sorting;

namespace Tests.Sorting
{
    [TestClass]
    public class InsertionSortPart2Test
    {
        private InsertionSortPart2 _insertionSortPart2;

        [TestInitialize]
        public void Initialize()
        {
            _insertionSortPart2 = new InsertionSortPart2();
        }

        #region Example Tests

        [TestMethod]
        public void InsertionSortPart2_Example_Test_1()
        {
            var arr = new [] { 1, 4, 3, 5, 6, 2 };

            var shifts = new List<int[]>
            {
                new [] {1, 4, 3, 5, 6, 2},
                new [] {1, 3, 4, 5, 6, 2 },
                new [] {1, 3, 4, 5, 6, 2 },
                new [] {1, 3, 4, 5, 6, 2 },
                new [] {1, 2, 3, 4, 5, 6 }
            };

            var result = _insertionSortPart2.solution(arr);

            for (var i = 0; i < result.Count; i++)
            {
                CollectionAssert.AreEqual(shifts[i], result[i]);
            }
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion
    }
}
