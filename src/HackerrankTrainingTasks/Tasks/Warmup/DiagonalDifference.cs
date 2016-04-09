using System;

namespace Tasks.Warmup
{
    public class DiagonalDifference
    {
        public int solution(int[][] a)
        {
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (i == j)
                    {
                        primaryDiagonalSum += a[i][j];
                    }
                    if (i + j == a.Length - 1)
                    {
                        secondaryDiagonalSum += a[i][j];
                    }
                }
            }

            return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
        }
    }
}
