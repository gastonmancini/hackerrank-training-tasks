using System;
using System.Linq;

namespace Tasks.Strings
{
    public class Anagram
    {
        public int solution(string text)
        {
            if (text.Length%2 != 0) return -1;

            var s1 = text.Substring(0, text.Length/2).ToCharArray();
            var s2 = text.Substring(text.Length/2, text.Length/2).ToCharArray();

            var letters = new int[26];

            // Count number of ocurrences of characters in the first string
            foreach (char c in s1)
            {
                int position = c - 'a';
                letters[position]++;
            }

            // Decrease the ocurrences of the letters in the second string
            foreach (char c in s2)
            {
                int position = c - 'a';
                if (letters[position] > 0)
                {
                    letters[position]--;
                }
            }

            return letters.Sum(Math.Abs);
        }
    }
}
