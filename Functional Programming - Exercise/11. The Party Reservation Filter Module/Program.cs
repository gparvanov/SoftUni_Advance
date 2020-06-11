using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            HashSet<string> junkFilters = new HashSet<string>();
            Queue<string> filters = new Queue<string>();
            string command = Console.ReadLine();

            while(command!= "Print")
            {
                string[] commandParts = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                if(commandParts[0] == "Add filter")
                {
                    junkFilters.Add(commandParts[1] + ";" + commandParts[2]);
                }
                else if (commandParts[0] == "Remove filter")
                {
                    junkFilters.Remove(commandParts[1] + ";" + commandParts[2]);
                }
                command = Console.ReadLine();
            }
            foreach (var filter in junkFilters)
            {
                filters.Enqueue(filter);
            }
            PrintArray(names, filters);
        }
        private static void PrintArray(List<string> names, Queue<string> filters)
        {
            while (filters.Count > 0)
            {
                string[] currentFilter = filters.Dequeue().Split(";",StringSplitOptions.RemoveEmptyEntries);
                string filterType = currentFilter[0];
                switch (filterType)
                {
                    case "Starts with":
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (names[i].StartsWith(currentFilter[1]))
                            {
                                names.Remove(names[i]);
                                i--;
                            }
                        }
                        break;
                    case "Ends with":
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (names[i].EndsWith(currentFilter[1]))
                            {
                                names.Remove(names[i]);
                                i--;
                            }
                        }
                        break;
                    case "Length":
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (names[i].Length == int.Parse(currentFilter[1]))
                            {
                                names.Remove(names[i]);
                                i--;
                            }
                        }
                        break;
                    case "Contains":
                        for (int i = 0; i < names.Count; i++)
                        {
                            if (names[i].Contains(currentFilter[1]))
                            {
                                names.Remove(names[i]);
                                i--;
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ",names));
        }
    }
}