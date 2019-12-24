using System;
using Easy_csharp.FindNumbers;
namespace Easy_csharp
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] test = new int[] {23,5435,363};
            Console.WriteLine(FindNumbers.Solution(test));
   
            Console.Read();
        }
    }
}
