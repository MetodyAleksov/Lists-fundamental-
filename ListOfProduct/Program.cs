using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOfProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> n = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Console.WriteLine(n.Count);
        }
    }
}
