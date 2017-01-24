using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks.Sorting
{
    public class Quicksort2Sorting
    {
        public int[] solution(int[] arr)
        {
            if (arr.Length == 0) return new int[0];

            if (arr.Length == 2)
            {
                if (arr[0] > arr[1])
                {
                    var aux = arr[1];
                    arr[1] = arr[0];
                    arr[0] = aux;
                }
                return arr;
            }

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

            return solution(left.ToArray()).Concat(equal.ToArray()).Concat(solution(right.ToArray())).ToArray();
        }
        
    }
}
