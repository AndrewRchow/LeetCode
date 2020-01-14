using System;
using System.Text;

namespace Easy_csharp
{
    public static class RemoveOuterParentheses1
    {
        public static string RemoveOuterParentheses(string S)
        {
            StringBuilder s = new StringBuilder();
            int opened = 0;
            foreach (char c in S)
            {
                if (c == '('){
                      if(opened> 0){
                        s.Append(c);
                    }
                    opened++;
                  
                } 
                if (c == ')'){
                      if(opened>1){
                        s.Append(c);
                    }
                    opened--;
                  
                } 
            }
            return s.ToString();
        }


        public static void Test()
        {

        }
    }
}
