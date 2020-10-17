using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());
            List<string> command = Console.ReadLine()
                .Split()
                .ToList();
            while(command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    passengers.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < passengers.Count; i++)
                    {
                        if (passengers[i] + int.Parse(command[0]) <= capacity)
                        {
                            passengers[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }
                command = Console.ReadLine()
                .Split()
                .ToList();
            }
            Console.WriteLine(string.Join(" ", passengers));
        }
    }
}
