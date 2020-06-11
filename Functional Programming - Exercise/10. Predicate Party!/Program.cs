using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (command != "Party!")
            {
                ManipulateList(names, command);
                command = Console.ReadLine();
            }
            if (names.Count > 0) Console.WriteLine($"{string.Join(", ",names)} are going to the party!");
            else Console.WriteLine("Nobody is going to the party!");
        }
        private static void ManipulateList(List<string> names, string command)
        {
            string[] data = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            switch (data[0])
            {
                case "Remove":
                    switch (data[1])
                    {
                        case "StartsWith":
                            for (int i = 0; i < names.Count; i++)
                            {
                                if (names[i].StartsWith(data[2]))
                                {
                                    names.RemoveAt(i);
                                    i--;
                                }
                                
                            }
                            break;
                        case "EndsWith":
                            for (int i = 0; i < names.Count; i++)
                            {
                                if (names[i].EndsWith(data[2]))
                                {
                                    names.RemoveAt(i);
                                    i--;
                                }                                
                            }
                            break;
                        case "Length":
                            for (int i = 0; i < names.Count; i++)
                            {
                                if (names[i].Length == int.Parse(data[2]))
                                {
                                    names.RemoveAt(i);
                                    i--;
                                }                                
                            }
                            break;
                    }
                    break;
                case "Double":
                    switch (data[1])
                    {
                        case "StartsWith":
                            for (int i = 0; i < names.Count; i++)
                            {
                                if (names[i].StartsWith(data[2]))
                                {
                                    names.Insert(i, names[i]);
                                    i++;
                                }                                
                            }
                            break;
                        case "EndsWith":
                            for (int i = 0; i < names.Count; i++)
                            {
                                if (names[i].EndsWith(data[2]))
                                {
                                    names.Insert(i, names[i]);
                                    i++;
                                }
                            }
                            break;
                        case "Length":
                            for (int i = 0; i < names.Count; i++)
                            {
                                if (names[i].Length == int.Parse(data[2]))
                                {
                                    names.Insert(i, names[i]);
                                    i++;
                                }
                            }
                            break;
                    }
                    break;
            }
        }
    }
}