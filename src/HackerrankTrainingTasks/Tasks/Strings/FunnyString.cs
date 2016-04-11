using System;
using System.Linq;

namespace Tasks.Strings
{
    public class FunnyString
    {
        public bool solution(string text)
        {
            var reverse = text.Reverse().ToArray();

            for (int i = 1; i < text.Length; i++)
            {
                if (Math.Abs(text[i] - text[i-1]) != Math.Abs(reverse[i] - reverse[i - 1])) return false;
            }

            return true;
        }
    }
}
