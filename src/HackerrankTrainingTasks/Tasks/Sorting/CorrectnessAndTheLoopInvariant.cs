namespace Tasks.Sorting
{
    public class CorrectnessAndTheLoopInvariant
    {
        /// Challenge: In the InsertionSort code below, there is an error. Can you fix it?
        public int[] solution(int[] A)
        {
            var j = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i]; // Stage Initialization - OK
                j = i - 1;
                while (j >= 0 && value < A[j]) // Stage Maintenance  - FAIL -  j >= 0 instead of j > 0
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;
            } // Stage Termination  - OK
            return A;
        }
    }
}
