namespace Tasks.Sorting
{
    public class RunningTimeOfAlgorithms
    {
        public int solution(int[] arr)
        {
            var shiftsCount = 0;

            for (var counter = 0; counter < arr.Length - 1; counter++)
            {
                for (var index = counter + 1; index > 0; index--)
                {
                    if (arr[index - 1] <= arr[index]) continue;

                    var aux = arr[index - 1];
                    arr[index - 1] = arr[index];
                    arr[index] = aux;
                    shiftsCount++;
                }
            }

            return shiftsCount;
        }
    }
}
