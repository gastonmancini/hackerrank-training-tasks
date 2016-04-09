namespace Tasks.Warmup
{
    public class PlusMinus
    {
        public void solution(int[] arr, out double positiveNumbersFraction, out double negativeNumbersFraction, out double zeroNumbersFraction)
        {
            int positiveNumbersCount = 0;
            int negativeNumbersCount = 0;
            int zeroNumbersCount = 0;

            foreach (var number in arr)
            {
                if (number < 0)
                {
                    negativeNumbersCount++;
                } else if (number > 0)
                {
                    positiveNumbersCount++;
                }
                else
                {
                    zeroNumbersCount++;
                }
            }

            positiveNumbersFraction = (double) positiveNumbersCount / arr.Length;
            negativeNumbersFraction = (double) negativeNumbersCount / arr.Length;
            zeroNumbersFraction = (double) zeroNumbersCount / arr.Length;
        }
    }
}
