namespace Tasks.Strings
{
    public class AlternatingCharacters
    {
        public int solution(string input)
        {
            char previousLetter = '\0';
            int deletionsRequired = 0;

            foreach (char letter in input)
            {
                if ((previousLetter == 'A' && letter == 'A') ||
                    (previousLetter == 'B' && letter == 'B'))
                {
                    deletionsRequired++;
                }

                previousLetter = letter;
            }

            return deletionsRequired;
        }
    }
}
