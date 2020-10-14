using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Lists_Fundamentals_
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list1 = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();
			List<int> list2 = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();
			List<int> newlist = new List<int>();
			if (list1.Count >= list2.Count)
			{
				for (int i = 0; i < list1.Count; i++)
				{
					newlist.Add(list1[i]);
					if (i < list2.Count)
                    {
						newlist.Add(list2[i]);
                    }
				}
			}
			else
            {
                for (int i = 0; i < list2.Count; i++)
                {
					if (i < list1.Count)
                    {
						newlist.Add(list1[i]);
                    }
					newlist.Add(list2[i]);
				}
            }
            Console.WriteLine(string.Join(" ", newlist));
		}
	}
}
