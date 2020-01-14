using System;
using System.Collections.Generic;
using System.Linq;

namespace Easy_csharp
{
    public static class SumZero1
    {
        public static int[] SumZero(int n)
        {
            var result = new List<int>();
            for (int i = 1; i <= n / 2; i++)
            {
                result.Add(i);
                result.Add(-i);
            }

            if (n % 2 == 1) result.Add(0);
            return result.ToArray();
        }

        public static void Test()
        {

        }
    }
}
