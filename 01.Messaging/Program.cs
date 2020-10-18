using System;
using System.Collections.Generic;
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
			List<char> finalSentence = new List<char>();
			foreach (int item in numbers)
			{
				int n = item;
				int sum = 0;
				while (n != 0)
				{
					sum += n % 10;
					n /= 10;
				}
				int counter = 0;
				for (int i = 1; i <= sum; i++)
				{
					if (counter >= sentence.Length)
					{
						counter = 0;
					}
					if (i == sum)
					{
						finalSentence.Add(sentence[counter]);
						sentence.RemoveAt(counter)

					}
				}
			}
			Console.WriteLine(string.Join("", finalSentence));
		}
	}
}
