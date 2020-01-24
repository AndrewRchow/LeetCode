using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Easy_csharp
{
    public static class CalculateTime1
    {
        public static int CalculateTime(string keyboard, string word)
        {
            Dictionary<char,int> map = new Dictionary<char,int>();
            for (int i = 0; i < keyboard.Length; i++)
            {
                map[keyboard[i]] = i;
            }

            int steps = 0;
            int location = 0;
            for (int i = 0; i < word.Length; i++)
            {
                steps += Math.Abs(map[word[i]] - location);
                location = map[word[i]];
            }
            return steps;
        }

        public static void Test()
        {

        }
    }
}
