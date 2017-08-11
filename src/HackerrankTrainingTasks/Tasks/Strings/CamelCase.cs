namespace Tasks.Strings
{
    public class CamelCase
    {
        public int solution(string s)
        {
            int count = 1;

            foreach (var character in s)
            {
                // Uppercase letters are between 65 and 90 in ASCII
                if (character >= 65 && character <= 90) 
                {
                    count++;
                }
            }

            return count;
        }
    }
}
