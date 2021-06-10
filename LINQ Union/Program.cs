using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_ConcatinateUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence1 = new List<int> { 1, 2, 3, 4 };
            List<int> sequence2 = new List<int> { 2, 4, 6, 8 };
            var result = sequence1.Union(sequence2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
