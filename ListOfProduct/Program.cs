using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOfProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> listOfProducts = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                listOfProducts.Add(input);
            }
            for (int i = 0; i < listOfProducts.Count; i++)
            {
                Console.WriteLine($"{i+1}. {listOfProducts[i]}");
            }
        }
    }
}
