using System.Collections.Generic;
using System.Linq;

namespace Tasks.Sorting
{
    public class Quicksort1Partition
    {
        public int[] solution(int[] arr)
        {
            var left = new List<int>();
            var equal = new List<int>();
            var right = new List<int>();

            var pivot = arr[0];

            foreach (var number in arr)
            {
                if (number < pivot) left.Add(number);
                if (number == pivot) equal.Add(number);
                if (number > pivot) right.Add(number);
            }

            return left.Concat(equal).Concat(right).ToArray();
        }
    }
}
