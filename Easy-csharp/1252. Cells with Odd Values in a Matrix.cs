using System;
using System.Collections;

namespace Easy_csharp
{
    public static class OddCells1
    {
        public static int OddCells(int n, int m, int[][] indices)
        {
            var rows = new BitArray(n);
            var rows_count = 0;
            var cols = new BitArray(m);
            var cols_count = 0;
            foreach (var index in indices)
            {
                rows.Set(index[0], !rows.Get(index[0]));
                rows_count += rows.Get(index[0]) ? 1 : -1;
                cols.Set(index[1], !cols.Get(index[1]));
                cols_count += cols.Get(index[1]) ? 1 : -1;
            }
            return rows_count * (m - cols_count) + cols_count * (n - rows_count);
        }

        public static void Test()
        {

        }
    }
}
