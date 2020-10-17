using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.ListOperations
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
            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) < numbers.Count)
                    {
                        numbers.RemoveAt(int.Parse(command[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) < numbers.Count)
                    {
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "Shift" && command[1] == "left")
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }
                else if (command[0] == "Shift" && command[1] == "right")
                {
                    for (int i = 0; i < int.Parse(command[2]); i++)
                    { 
                        numbers.Insert(0, numbers[numbers.Count - 1]);
                        numbers.RemoveAt(numbers.Count-1);
                    }
                }
                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
