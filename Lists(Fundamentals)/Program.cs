using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lists_Fundamentals_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            bool isChanged = false;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                List<string> command = input
                    .Split()
                    .ToList();
                if (command[0] == "Add")
                {
                    list.Add(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "Remove")
                {
                    list.Remove(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    list.RemoveAt(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "Insert")
                {
                    list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "Contains")
                {
                    Contains(list, int.Parse(command[1]));
                }
                else if (command[0] == "PrintEven")
                {
                    PrintEven(list);
                }
                else if (command[0] == "PrintOdd")
                {
                    PrintOdd(list);
                }
                else if (command[0] == "GetSum")
                {
                    GetSum(list);
                }
                else if (command[0] == "Filter")
                {
                    Filter(list, command);
                }
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", list));
            }

        }
        static void Contains(List<int> n, int n1)
        {
            bool contains = false;
            foreach (int item in n)
            {
                if (item == n1)
                {
                    contains = true;
                    break;
                }
            }
            if (contains)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        static void PrintEven(List<int> n)
        {
            List<int> evenNums = new List<int>(5);
            for (int i = 0; i < n.Count; i++)
            {
                if (n[i] % 2 == 0)
                {
                    evenNums.Add(n[i]);
                }
            }
            Console.WriteLine(string.Join(" ", evenNums));
        }
        static void PrintOdd(List<int> n)
        {
            List<int> evenNums = new List<int>(5);
            for (int i = 0; i < n.Count; i++)
            {
                if (n[i] % 2 != 0)
                {
                    evenNums.Add(n[i]);
                }
            }
            Console.WriteLine(string.Join(" ", evenNums));
        }
        static void GetSum(List<int> n)
        {
            int sum = 0;
            for (int i = 0; i < n.Count; i++)
            {
                sum += n[i];
            }
            Console.WriteLine(sum);
        }
        static void Filter(List<int> n, List<string> command)
        {
            List<int> finalList = new List<int>();
            for (int i = 0; i < n.Count; i++)
            {
                if (command[1] == "<" && int.Parse(command[2]) > n[i])
                {
                    finalList.Add(n[i]);
                }
                else if (command[1] == "<=" && int.Parse(command[2]) >= n[i])
                {
                    finalList.Add(n[i]);
                }
                else if (command[1] == ">" && int.Parse(command[2]) < n[i])
                {
                    finalList.Add(n[i]);
                }
                else if (command[1] == ">=" && int.Parse(command[2]) <= n[i])
                {
                    finalList.Add(n[i]);
                }
            }
            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
