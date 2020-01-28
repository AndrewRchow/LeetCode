using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace Easy_csharp
{
    public static class IsValid1
    {
        public static bool IsValid(string s)
        {

            Stack stack = new Stack();

            for (int i = 0; i < s.Length; i++)
            {
                if (IsOpen(s[i]))
                    stack.Push(s[i]);
                else
                {
                    if(stack.Count == 0){
                        return false;
                    }
                    var top = (char)stack.Pop();
                    if (
                        (top== '(' && s[i]!=')') ||
                        (top== '{' && s[i]!='}') ||
                        (top== '[' && s[i]!=']') 
                    )
                    {
                        return false;
                    }
                }

            }
            return stack.Count ==0;
        }

        public static bool IsOpen(char c)
        {
            return c == '[' || c == '{' || c == '(';
        }

        public static void Test()
        {
            String a = "{}]()";

            Console.WriteLine(IsValid(a));
            Console.Read();

        }
    }
}
