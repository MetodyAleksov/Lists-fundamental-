using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _10.SoftUniCoursePlaning
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> program = Console.ReadLine()
				.Split(", ", StringSplitOptions.RemoveEmptyEntries)
				.ToList();
			List<string> command = Console.ReadLine()
				.Split(":", StringSplitOptions.RemoveEmptyEntries)
				.ToList();
			while (command[0] != "course start")
			{
				if (command[0] == "Add")
				{
					if (program.Contains(command[1]) == false)
					{
						program.Add(command[1]);
					}
				}
				else if (command[0] == "Insert")
				{
					if (program.Contains(command[1]) == false)
					{
						program.Insert(int.Parse(command[2]), command[1]);
					}
				}
				else if (command[0] == "Remove")
				{
					if (program.Contains(command[1]))
					{
						if (program.Contains($"{command[1]}-Exercise"))
                        {
							program.RemoveAt(program.IndexOf(command[1]) + 1);
						}
						program.Remove(command[1]);
					}
				}
				else if (command[0] == "Swap")
				{
					string item1 = command[1];
					string item2 = command[2];
					int index1 = program.IndexOf(item1);
					int index2 = program.IndexOf(item2);
					program[index1] = item2;
					program[index2] = item1;
					if (program.Contains($"{command[1]}-Exercise"))
					{
						string ex1 = $"{command[1]}-Exercise";
						program.Remove(ex1);
						if (index2 + 1 >= program.Count - 1)
						{
							program.Add(ex1);
						}
						else
						{
							program.Insert(index2 + 1, ex1);
						}
					}
					if (program.Contains($"{command[2]}-Exercise"))
					{
						string ex1 = $"{command[2]}-Exercise";
						program.Remove(ex1);
						if (index1 + 1 >= program.Count - 1)
                        {
							program.Add(ex1);
                        }
						else
                        {
							program.Insert(index1 + 1, ex1);
						}
					}
				}
				else if (command[0] == "Exercise")
                {
					if (program.Contains(command[1]))
                    {
						if (program.Contains($"{command[1]}-Exercise") == false)
                        {
                            program.Insert(program.IndexOf(command[1])+1, $"{command[1]}-Exercise");
                        }
                    }
					else
                    {
						program.Add(command[1]);
						program.Add($"{command[1]}-Exercise");
                    }
                }
				command = Console.ReadLine()
				.Split(":", StringSplitOptions.RemoveEmptyEntries)
				.ToList();
			}
            for (int i = 0; i < program.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{program[i]}");
            }
		}
		
	}
}
