using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            list1.Reverse();
            List<string> final = new List<string>();
            foreach (string item in list1)
            {
                string[] nums = item
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                foreach (string number in nums)
                {
                    final.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", final));
        }
    }
}
