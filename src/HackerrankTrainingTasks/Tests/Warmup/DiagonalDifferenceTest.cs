using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Warmup;

namespace Tests.Warmup
{
    [TestClass]
    public class DiagonalDifferenceTest
    {
        private DiagonalDifference _diagonalDifference;

        [TestInitialize]
        public void Initialize()
        {
            _diagonalDifference = new DiagonalDifference();
        }

        #region Example Tests

        [TestMethod]
        public void DiagonalDifference_Example_Test()
        {
            int matrixSize = 3;
            var matrix = new int[matrixSize][];
            matrix[0] = new int[matrixSize];
            matrix[1] = new int[matrixSize];
            matrix[2] = new int[matrixSize];

            matrix[0][0] = 11;
            matrix[0][1] = 2;
            matrix[0][2] = 4;
            matrix[1][0] = 4;
            matrix[1][1] = 5;
            matrix[1][2] = 6;
            matrix[2][0] = 10;
            matrix[2][1] = 8;
            matrix[2][2] = -12;

            Test(matrix, 15);
        }

        #endregion

        #region Extremes tests

        // TODO

        #endregion

        private void Test(int[][] matrix, int expectedResult)
        {
            var result = _diagonalDifference.solution(matrix);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
