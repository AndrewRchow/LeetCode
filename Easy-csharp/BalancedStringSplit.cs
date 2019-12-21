using System;

namespace Easy_csharp
{
    public static class BalancedStringSplit
    {
        public static int Solution(string s) {
            int max=0;
            int count = 0;
            for (var i=0; i<s.Length; i++){
              if(s[i].Equals('L')){
                  count++;
              }else {
                  count--;
              }
              if(count==0){
                  max++;
              }
            }
            return max;

        }
    }
}
