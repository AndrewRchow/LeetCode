using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace Easy_csharp
{
    public static class CountLetters1
    {
        public static int CountLetters(string S)
        {
            int streak = 0;
            char start = S[0];
            int output = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == start)
                {
                    streak++;
                }
                else
                {
                    output += Binomial(streak);
                    streak = 1;
                    start = S[i];
                }

                if (i == S.Length - 1)
                {
                    output += Binomial(streak);
                }
            }
            return output;
        }

        public static int Binomial(int a)
        {
            return a * (a + 1) / 2;
        }
        public static void Test()
        {
            Console.WriteLine(CountLetters("aaab"));
        }
    }
}
