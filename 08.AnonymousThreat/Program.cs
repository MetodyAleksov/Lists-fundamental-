using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> command = Console.ReadLine()
                .Split()
                .ToList();
            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int endIndex = int.Parse(command[2]);
                    int beginIndex = int.Parse(command[1]);
                    if (endIndex >= sequence.Count - 1)
                    {
                        endIndex = sequence.Count - 1;
                    }
                    if (beginIndex < 0)
                    {
                        beginIndex = 0;
                    }
                    for (int i = beginIndex; i <= endIndex; i++)
                    {

                    }
                    sequence.RemoveRange(beginIndex + 1, endIndex + beginIndex + 1);
                }
                else if (command[0] == "divide")
                {

                }
            }
        }
    }
}
