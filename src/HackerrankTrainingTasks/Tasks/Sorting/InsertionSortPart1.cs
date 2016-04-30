using System.Collections.Generic;

namespace Tasks.Sorting
{
    public class InsertionSortPart1
    {
        public IList<int[]> solution(int[] arr)
        {
            var shifts = new List<int[]>();

            var unorderedValue = arr[arr.Length - 1];

            for (var i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == unorderedValue)
                    continue;

                if (arr[i] > unorderedValue)
                {
                    arr[i + 1] = arr[i];
                }

                if (arr[i] < unorderedValue)
                {
                    arr[i + 1] = unorderedValue;
                    shifts.Add((int[])arr.Clone());
                    break;
                }

                shifts.Add((int[]) arr.Clone());
            }

            return shifts;
        }
    }
}
