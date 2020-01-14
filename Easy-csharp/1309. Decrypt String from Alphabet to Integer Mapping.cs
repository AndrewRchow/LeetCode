using System;
using System.Collections.Generic;

namespace Easy_csharp
{
    public static class FreqAlphabets1
    {
        public static string FreqAlphabets(string s)
        {
            Dictionary<string, string> letters = new Dictionary<string, string>()
        {
            { "1", "a" },
            { "2", "b" },
            { "3", "c" },
            { "4", "d" },
            { "5", "e" },
            { "6", "f" },
            { "7", "g" },
            { "8", "h" },
            { "9", "i" },
            { "10#", "j" },
            { "11#", "k" },
            { "12#", "l" },
            { "13#", "m" },
            { "14#", "n" },
            { "15#", "o" },
            { "16#", "p" },
            { "17#", "q" },
            { "18#", "r" },
            { "19#", "s" },
            { "20#", "t" },
            { "21#", "u" },
            { "22#", "v" },
            { "23#", "w" },
            { "24#", "x" },
            { "25#", "y" },
            { "26#", "z" },
        };

            string output = "";
            for (var i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '#')
                {
                    var seq = s.Substring(i - 2, 3);
                    output = letters[seq] + output;
                    i -= 2;
                }
                else
                {
                    output = letters[s[i].ToString()] + output;
                }
            }
            return output;
        }

        public static void Test()
        {
            char c = 'a';
            int r = 2;
            c += (char)r;
            Console.WriteLine((char)('j' + 2));
            Console.WriteLine(FreqAlphabets("10#11#12"));
        }
    }
}
