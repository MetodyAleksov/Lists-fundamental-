using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            List<int> car1 = new List<int>();
            List<int> car2 = new List<int>();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                car1.Add(arr[i]);
            }
            for (int i = arr.Length - 1; i > arr.Length / 2; i--)
            {
                car2.Add(arr[i]);
            }
            double sumCar1 = 0;
            foreach (int item in car1)
            {
                if (item == 0)
                {
                    sumCar1 *= 0.80;
                }
                else
                {
                    sumCar1 += item;
                }
            }
            double sumCar2 = 0;
            foreach (int item in car2)
            {
                if (item == 0)
                {
                    sumCar2 *= 0.80;
                }
                else
                {
                    sumCar2 += item;
                }
            }
            string winner = String.Empty;
            double winningTime = 0;
            if (sumCar1 <= sumCar2)
            {
                winner = "left";
                winningTime = sumCar1;
            }
            else
            {
                winner = "right";
                winningTime = sumCar2;
            }
            Console.WriteLine($"The winner is {winner} with total time: {winningTime}");
        }
    }
}
