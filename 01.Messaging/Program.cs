using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;

namespace _01.Messaging
{
	class Program
	{
		static void Main(string[] args)
		{

			List<int> numbers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();
			string sentence = Console.ReadLine();
			List<char> actualSentence = sentence.ToList();
			List<char> finalSentence = new List<char>();
            foreach (int item in numbers)
            {
				int sum = 0;
				int n = item;
				while (n != 0)
				{
					sum += n % 10;
					n /= 10;
				}
				int counter = 0;
                for (int i = 0; i < sum; i++)
                {
					if (counter == sentence.Length)
                    {
						counter = 0;
                    }
					if (i == sum - 1)
                    {
						finalSentence.Add(actualSentence[counter]);
						actualSentence.RemoveAt(counter);
                    }
					counter++;
                }
				counter = 0;
			}
            Console.WriteLine(string.Join("", finalSentence));
		}
	}
}
