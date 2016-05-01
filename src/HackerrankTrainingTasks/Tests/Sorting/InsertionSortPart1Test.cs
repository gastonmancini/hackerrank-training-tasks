using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Sorting;

namespace Tests.Sorting
{
    [TestClass]
    public class InsertionSortPart1Test
    {
        private InsertionSortPart1 _insertionSortPart1;

        [TestInitialize]
        public void Initialize()
        {
            _insertionSortPart1 = new InsertionSortPart1();
        }

        #region Example Tests

        [TestMethod]
        public void InsertionSortPart1_Example_Test_1()
        {
            var arr = new [] {2, 4, 6, 8, 3 };

            var shifts = new List<int[]>
            {
                new [] {2, 4, 6, 8, 8 },
                new [] {2, 4, 6, 6, 8 },
                new [] {2, 4, 4, 6, 8 },
                new [] {2, 3, 4, 6, 8 }
            };

            var result = _insertionSortPart1.solution(arr);

            for (var i = 0; i < result.Count; i++)
            {
                CollectionAssert.AreEqual(shifts[i], result[i]);
            }
        }

        [TestMethod]
        public void InsertionSortPart1_Example_Test_2()
        {
            var arr = new[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 };

            var shifts = new List<int[]>
            {
                new [] {2, 3, 4, 5, 6, 7, 8, 9, 10, 10},
                new [] {2, 3, 4, 5, 6, 7, 8, 9, 9, 10},
                new [] {2, 3, 4, 5, 6, 7, 8, 8, 9, 10},
                new [] {2, 3, 4, 5, 6, 7, 7, 8, 9, 10},
                new [] {2, 3, 4, 5, 6, 6, 7, 8, 9, 10},
                new [] {2, 3, 4, 5, 5, 6, 7, 8, 9, 10},
                new [] {2, 3, 4, 4, 5, 6, 7, 8, 9, 10},
                new [] {2, 3, 3, 4, 5, 6, 7, 8, 9, 10},
                new [] {2, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
            };

            var result = _insertionSortPart1.solution(arr);

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
