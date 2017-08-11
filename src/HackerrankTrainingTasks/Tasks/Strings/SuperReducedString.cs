namespace Tasks.Strings
{
    public class SuperReducedString
    {
        public string solution(string s)
        {
            if (s.Length == 1) return s;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == s[i])
                {
                    s = s.Remove(i - 1, 2);
                    i = 0;
                }
            }

            if (s.Length == 0) return "Empty String";

            return s;
        }
    }
}
