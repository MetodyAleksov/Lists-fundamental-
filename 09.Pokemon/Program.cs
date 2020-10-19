using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace _09.Pokemon
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> pokemons = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();
			int index = int.Parse(Console.ReadLine());
			int sum = 0;
			bool wasInvalid = false;
			while (pokemons.Count - 1!= 0)
			{
				if (index < 0)
				{
					index = 0;
					pokemons[0] = pokemons[pokemons.Count - 1];
					wasInvalid = true;
				}
				else if (index > pokemons.Count - 1)
				{
					index = pokemons.Count - 1;
					pokemons[pokemons.Count - 1] = pokemons[0];
					wasInvalid = true;
				}
				int removedNum = pokemons[index];
				sum += removedNum;
				if (wasInvalid == false)
				{
					pokemons.RemoveAt(index);
				}
                for (int i = 0; i < pokemons.Count; i++)
                {
					if (pokemons[i] <= removedNum)
                    {
						pokemons[i] += removedNum;
                    }
					else
                    {
						pokemons[i] -= removedNum;
                    }
                }
				wasInvalid = false;
				index = int.Parse(Console.ReadLine());
			}
			sum += pokemons[0];
            Console.WriteLine(sum);
		}
	}
}
