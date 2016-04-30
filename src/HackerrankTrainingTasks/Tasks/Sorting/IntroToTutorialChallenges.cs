namespace Tasks.Sorting
{
    public class IntroToTutorialChallenges
    {
        public int solution(int[] arr, int numberToInsert)
        {
            var index = 0;

            foreach (var number in arr)
            {
                if (number >= numberToInsert) return index;
                index++;
            }

            return index;
        }
    }
}
