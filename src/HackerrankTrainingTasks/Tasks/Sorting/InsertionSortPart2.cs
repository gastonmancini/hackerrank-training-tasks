using System.Collections.Generic;

namespace Tasks.Sorting
{
    /// <summary>
    /// Insertion sort is an elementary sorting algorithm that sorts one element at a time. 
    /// The algorithm takes an element from the list and places it in the correct location in the list.
    /// This process is repeated until there are no more unsorted items in the list. The computational complexity for insertion sort is O(n2).
    /// </summary>
    public class InsertionSortPart2
    {
        public IList<int[]> solution(int[] arr)
        {
            var shifts = new List<int[]>();

            for (var counter = 0; counter < arr.Length - 1; counter++)
            {
                for (var index = counter + 1; index > 0; index--)
                {
                    if (arr[index - 1] <= arr[index]) continue;

                    var aux = arr[index - 1];
                    arr[index - 1] = arr[index];
                    arr[index] = aux;
                }

                shifts.Add((int[])arr.Clone());
            }

            return shifts;
        }
    }
}
