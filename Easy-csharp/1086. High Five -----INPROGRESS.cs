using System;
using System.Collections.Generic;
using System.Text;


namespace Easy_csharp
{
    public static class HighFive1
    {
        public static int[][] HighFive(int[][] items)
        {
            var dict = new Dictionary<int, List<int>>();
            for (int i = 0; i < items.Length; i++)
            {
                var id = items[i][0];
                var score = items[i][1];
                if (dict.ContainsKey(id))
                {
                    dict[id].Add(score);
                }
                else
                {
                    dict.Add(id, new List<int>());
                }
            }

            var j = 0;
            var output = new int[dict.Count][];

            foreach (var entry in dict)
            {
                entry.Value.Sort();
                int total = 0;
                for (var i = entry.Value.Count-1; i >= entry.Value.Count - 5; i--)
                {
                    total += entry.Value[i];
                }

                output[j] = new int[2] { entry.Key, total / 5 };

                j++;
            }
            return output;
        }

        public static void Test()
        {
            int[][] jaggedArray2 = new int[][]
            {
    new int[] { 1, 90 },
    new int[] { 2, 91 },
    new int[] { 1, 92 },
    new int[] { 1, 93 },
    new int[] { 2, 94 },
    new int[] { 2, 95 },
    new int[] { 2, 96 },
    new int[] { 2, 97 },
    new int[] { 1, 98 },
    new int[] { 1, 99 },
    new int[] { 1, 1 },
    new int[] { 1, 1 },
    new int[] { 1, 1 },

            };
  var test = HighFive(jaggedArray2);
            for (int x = 0; x < test.Length; x++)
            {
                for (int y = 0; y < test[x].Length; y++)
                {
                    Console.Write(test[x][y]);
                    if (y == test[x].Length - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}
