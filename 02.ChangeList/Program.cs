using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<string> command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    numbers = Delete(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static List<int> Delete(List<int> list, int n)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (n == list[i])
                {
                    list.Remove(n);
                }
            }
            return list;
        }
    }
}
