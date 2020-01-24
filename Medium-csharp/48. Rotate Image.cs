using System;
using System.Collections.Generic;
using System.Text;


namespace Medium_csharp
{
    public static class Rotate1
    {
        public static int[][] Rotate(int[][] matrix)
        {
       //get matrix's size to make the code clear, you don't have to be like this
            int size = matrix.Length-1;

            for (int i = 0; i < matrix.Length/2; i++)
            {
                for (int j = i; j < size-i; j++)
                {

                    //Circle the number to correct position
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[size-j][i];
                    matrix[size-j][i] = matrix[size-i][size-j];
                    matrix[size-i][size-j] = matrix[j][size-i];
                    matrix[j][size-i] = temp;

                }
            }

            return matrix;

        }

        public static void Test()
        {
            int[][] jaggedArray2 = new int[][]
            {
    new int[] { 1, 1, 1 },
    new int[] { 2, 2, 2},
    new int[] { 3, 3, 3},
            };

            var test = Rotate(jaggedArray2);
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