using System;

namespace Easy_csharp
{
    public static class FindNumbers
    {
        public static int Solution(int[] nums) {
            int output = 0;
            for(var i = 0; i < nums.Length; i++){
               var currentNumLength = nums[i].ToString().Length;
               if(currentNumLength %2==0)
                   output++;
            }

            return output;
        }
    }
}
