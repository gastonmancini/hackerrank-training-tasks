using System.Linq;

namespace Tasks.Strings
{
    public class Pangrams
    {
        // Returns true if the phrase is panagram, false otherwise
        public bool solution(string phrase)
        {
            phrase = string.Join("", phrase.Replace(" ", "").ToLowerInvariant().Distinct());

            if (phrase.Length != 26) return false;

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                phrase = phrase.Replace(letter.ToString(), "");
            }

            return string.IsNullOrEmpty(phrase);
        }
    }
}
