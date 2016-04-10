namespace Tasks.Strings
{
    public class TheLoveLetterMystery
    {
        public int solution(string input)
        {
            int operationsRequired = 0;

            var textArray = input.ToCharArray();

            for (int i = 0; i < textArray.Length / 2; i++)
            {
                operationsRequired += CalculateOperations(textArray[i], textArray[textArray.Length - 1 - i]);
            }
            
            return operationsRequired;
        }

        private int CalculateOperations(char c1, char c2)
        {
            if (c1 > c2) return c1 - c2;

            if (c1 < c2) return c2 - c1;

            return 0;
        }

        /*private bool isPalindrome(string text)
        {
            var textArray = text.ToCharArray();

            for (int i = 0; i < textArray.Length / 2; i++)
            {
                if (textArray[i] != textArray[textArray.Length - 1 - i]) return false;
            }

            return true;
        }*/
    }
}
