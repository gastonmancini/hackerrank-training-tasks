using System.Collections.Generic;
using System.Linq;

namespace Tasks.Strings
{
    public class TwoStrings
    {
        public bool solution(string firstString, string secondString)
        {
            var indexedSecondString = new HashSet<char>(secondString);
            return firstString.Any(indexedSecondString.Contains);
        }

        // Terminated due to timeout
        //public bool solution(string firstString, string secondString)
        //{
        //    return firstString.Any(secondString.Contains);
        //}
    }
}
