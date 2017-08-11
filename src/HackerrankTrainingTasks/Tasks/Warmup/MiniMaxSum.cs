namespace Tasks.Warmup
{
    public class MiniMaxSum
    {
        public string solution(int[] fiveNumbers)
        {
            long sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (var number in fiveNumbers)
            {
                sum += number;
                if (number < min) min = number;
                if (number > max) max = number;
            }

            return $"{sum - max} {sum - min}";
        }
    }
}
