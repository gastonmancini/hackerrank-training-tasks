using System;

namespace Tasks.Warmup
{
    public class Staircase
    {
        public string solution(int N)
        {
            var result = string.Empty;
            
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if (i + j <= N)
                    {
                        result += " ";
                    }
                    else
                    {
                        result += "#";
                    }
                }
                result += Environment.NewLine;
            }

            return result;
        }
    }
}
