using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsLab2
{
    class Program
    {
        static void Main()
        {
            var list = new List<string>() { "ab", "ad", "a", "bc", "b", "dsaf" };
            RadixSorting.Sorting(list, 4, 26);

            foreach (var str in list)
                Console.WriteLine(str);
        }
    }
}
