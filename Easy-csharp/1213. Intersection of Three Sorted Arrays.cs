using System;
using System.Collections.Generic;
using System.Text;


namespace Easy_csharp
{
    public static class ArraysIntersection1
    {
        public static IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int a in arr1)
            {
                if (!dict.ContainsKey(a))
                    dict.Add(a, 1);
                else
                    dict[a]++;
            }
            foreach (int a in arr2)
            {
                if (!dict.ContainsKey(a))
                    dict.Add(a, 1);
                else
                    dict[a]++;
            }
            foreach (int a in arr3)
            {
                if (!dict.ContainsKey(a))
                    dict.Add(a, 1);
                else
                    dict[a]++;
            }
            var output = new List<int>();
            foreach(KeyValuePair<int,int> entry in dict){
                
                if(entry.Value==3){
                    output.Add(entry.Key);
                }
            }
            return output.ToArray();
        }

        public static void Test()
        {

        }
    }
}
