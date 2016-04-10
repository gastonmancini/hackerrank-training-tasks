using System.Collections.Generic;
using System.Linq;

namespace Tasks.Strings
{
    public class Gemstones
    {
        public int solution(string[] rocks)
        {
            var intersection = rocks[0].ToCharArray();

            for (int i = 1; i < rocks.Length; i++)
            {
                intersection = intersection.Intersect(rocks[i].ToCharArray()).ToArray();
            }
            
            return intersection.Length;
        }
    }
}
