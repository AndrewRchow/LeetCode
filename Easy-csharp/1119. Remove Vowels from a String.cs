using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_csharp
{
    public static class removeVowels1
    {
        public static string RemoveVowels(string S)
        {
            var vowels = new List<char>() {
                'a', 'e','i','o','u'
            };

            StringBuilder output = new StringBuilder();

            foreach (char c in S)
            {
                if (!vowels.Contains(c))
                {
                    output.Append(c);
                }
            }
            return output.ToString();
        }

        public static void Test()
        {

        }
    }
}
