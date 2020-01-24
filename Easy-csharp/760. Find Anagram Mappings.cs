using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Easy_csharp
{
    public static class AnagramMappings1
    {
        public static int[] AnagramMappings(int[] A, int[] B)
        {
            Dictionary<int,int> map = new Dictionary<int, int>();
            for (int i = 0; i < B.Length; i++)
            {
                map[B[i]] = i;
            }

            int[] output = new int[A.Length];
            for (int i = 0; i < output.Length; i++)
            {
                output[i]=map[A[i]];
            }
            return output;
        }

        public static void Test()
        {

        }
    }
}
