using System.Collections.Generic;
using System.Linq;

namespace Tasks.Strings
{
    public class GameofThronesI
    {
        public bool solution(string input)
        {
            var letterCount = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                var count = 1;

                if (letterCount.ContainsKey(letter))
                {
                    count += letterCount[letter];
                }

                letterCount[letter] = count;
            }

            var oddCount = letterCount.Count(lc => lc.Value%2 == 1);
            return oddCount == 0 || oddCount == 1;
        }
    }
}
