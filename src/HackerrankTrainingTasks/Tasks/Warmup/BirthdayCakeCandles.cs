namespace Tasks.Warmup
{
    public class BirthdayCakeCandles
    {
        public int solution(int n, int[] ar)
        {
            int maximumCandleHeight = int.MinValue;
            int maximumCandleHeightCount = 0;

            foreach (var candleHeight in ar)
            {
                if (maximumCandleHeight < candleHeight)
                {
                    maximumCandleHeight = candleHeight;
                    maximumCandleHeightCount = 1;
                }
                else if (maximumCandleHeight == candleHeight)
                {
                    maximumCandleHeightCount++;
                }
            }

            return maximumCandleHeightCount;
        }
    }
}
