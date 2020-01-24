using System;
using System.Collections.Generic;
using System.Text;


namespace Easy_csharp
{
    public static class IsUgly1
    {
        public static bool IsUgly(int num)
        {
            if(num ==0)
                return false;
                
            for (int i = 2; i < 6; i++)
            {
                while(num%i==0){
                    num /= i;
                }
            }
            return num ==1;

        }

        public static void Test()
        {

        }
    }
}
