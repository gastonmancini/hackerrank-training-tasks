using System.Collections.Generic;
using System.Linq;

namespace Tasks.Strings
{
    public class PalindromeIndex
    {
        // TODO Improve solution - Current complexity = O(N^2)
        public int solution(string text)
        {
            if (isPalindrome(text.ToList())) return -1;

            for (int i = 0; i < text.Length; i++)
            {
                var charList = text.ToList();
                charList.RemoveAt(i);
                if (isPalindrome(charList)) return i;
            }

            return 0;
        }

        private bool isPalindrome(List<char> charList)
        {
            for (int i = 0; i < charList.Count / 2; i++)
            {
                if (charList[i] != charList[charList.Count - 1 - i]) return false;
            }

            return true;
        }

    }
}
