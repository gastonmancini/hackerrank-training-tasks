using System.Collections.Generic;
using System.Linq;

namespace Tasks.Strings
{
    public class TwoCharacters
    {
        public int solution(int len, string s)
        {
            var characters = GetDistinctChars(s);

            int maxSize = 0;

            for (int i = 0; i < characters.Length - 1; i++)
            {
                for (int j = i + 1; j < characters.Length; j++)
                {
                    var currentSize = CalculateSize(s, characters[i], characters[j]);

                    if (maxSize < currentSize) maxSize = currentSize;

                    currentSize = CalculateSize(s, characters[j], characters[i]);

                    if (maxSize < currentSize) maxSize = currentSize;
                }
            }

            if (maxSize == 1) maxSize = 0;

            return maxSize;
        }

        private static char[] GetDistinctChars(string s)
        {
            var characters = new HashSet<char>();

            foreach (var character in s)
            {
                if (!characters.Contains(character))
                {
                    characters.Add(character);
                }
            }

            return characters.ToArray();
        }

        private static int CalculateSize(string s, char firstChar, char secondChar)
        {
            int count = 0;
            var currentChar = firstChar;

            foreach (var character in s)
            {
                if (character == currentChar)
                {
                    currentChar = currentChar == firstChar ? secondChar : firstChar;

                    count++;
                }
                else
                {
                    if ((character == firstChar && currentChar == secondChar) ||
                        (character == secondChar && currentChar == firstChar))
                    {
                        return 0; // cannot be formed
                    }
                }
            }

            return count;
        }
    }
}
