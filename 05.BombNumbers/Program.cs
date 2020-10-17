using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> specialNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int indexOfSpecialNum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumbers[0])
                {
                    indexOfSpecialNum = i;
                    break;
                }
            }
            int powerCounter = specialNumbers[1];
            for (int i = numbers[indexOfSpecialNum - 1]; i >= indexOfSpecialNum - powerCounter; i--)
            {

            }
        }
    }
}
