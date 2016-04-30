using System.Collections.Generic;
using System.Linq;

namespace Tasks.Strings
{
    public class MakeItAnagram
    {
        public int solution(string firstString, string secondString)
        {
            var firstStringLettersCount = new Dictionary<char, int>();

            foreach (var letter in firstString)
            {
                var count = 1;
                if (firstStringLettersCount.ContainsKey(letter))
                {
                    count += firstStringLettersCount[letter];
                }
                firstStringLettersCount[letter] = count;
            }

            var deletionsRequired = 0;

            foreach (var letter in secondString)
            {
                if (firstStringLettersCount.ContainsKey(letter))
                {
                    if (firstStringLettersCount[letter] == 1)
                    {
                        firstStringLettersCount.Remove(letter);
                        continue;
                    }
                    firstStringLettersCount[letter]--;
                }
                else
                {
                    deletionsRequired++;
                }
            }
            
            deletionsRequired += firstStringLettersCount.Values.Sum(x => x);

            return deletionsRequired;
        }
    }
}
