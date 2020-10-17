using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int bomb = arr[0];
            int power = arr[1];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int startIndex = i - power;
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    int endIndex = i + power;
                    if (endIndex >= numbers.Count)
                    {
                        endIndex = numbers.Count - 1;
                    }
                    int indexToRemove = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, indexToRemove);
                    i = startIndex - 1;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
