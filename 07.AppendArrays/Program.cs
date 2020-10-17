using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> append = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> FinalList = new List<string>(append.Count);
            int indexer = 0;
            foreach (string item in append)
            {
                FinalList[indexer] = item.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToString();
                indexer++;
            }
            FinalList.Reverse();
            Console.WriteLine(string.Join(" ", FinalList));
        }
    }
}
