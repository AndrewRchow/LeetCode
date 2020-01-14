using System;

namespace Easy_csharp
{
    public static class MinTimeToVisitAllPointsClass
    {
        public static int MinTimeToVisitAllPoints(int[][] points)
        {
            var total = 0;
            for (var i = 0; i < points.Length - 1; i++)
            {
                var x1 = points[i][0];
                var y1 = points[i][1];
                var x2 = points[i + 1][0];
                var y2 = points[i + 1][1];

                var diffx = Math.Abs(x2 - x1);
                var diffy = Math.Abs(y2 - y1);

                if (diffy > diffx)
                    total += diffy;
                else
                    total += diffx;
            }

            return total;
        }

        public static void Test()
        {
            int[][] jaggedArray = new int[][]
                     {
                    new int[] { 1, 1 },
                    new int[] { 3, 4},
                    new int[] { -1, 0 }
                     };
                     
            Console.WriteLine(MinTimeToVisitAllPoints(jaggedArray));
        }
    }

}
