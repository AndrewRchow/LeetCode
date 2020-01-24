using System;
using System.Collections.Generic;
using System.Text;


namespace Easy_csharp
{
    public static class LongestCommonPrefix1
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0 || Array.IndexOf(strs, "") != -1)
                return "";
            string start = strs[0];
            int streak = start.Length;
            foreach (string word in strs)
            {
                int i = 0;
                foreach (char c in word)
                {
                    if(i < start.Length && start[i]==c){
                        i++;
                    }else{
                        break;
                    }
                }
                streak = Math.Min(streak, i);
            }
            return start.Substring(0, streak);
        }

        public static void Test()
        {
            var test = new string[] { "est", "est", "estdf" };
            Console.WriteLine(LongestCommonPrefix(test));

        }
    }
}
