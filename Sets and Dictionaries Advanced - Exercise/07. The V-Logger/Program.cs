using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vloggers = new HashSet<string>();
            Dictionary<string, List<int>> followedCount = new Dictionary<string, List<int>>();
            Dictionary<string, List<string>> followedNames = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while(command != "Statistics")
            {
                string[] inputData = command.Split();
                string vloggerName = inputData[0];
                if(inputData[1] == "joined")
                {
                    if (!vloggers.Contains(vloggerName))
                    {
                        vloggers.Add(vloggerName);
                        followedCount[vloggerName] = new List<int>();
                        followedCount[vloggerName].Add(0);
                        followedCount[vloggerName].Add(0);
                        followedNames[vloggerName] = new List<string>();                                                
                    }
                }
                else if (inputData[1] == "followed")
                {
                    string followedUser = inputData[2];
                    if (vloggers.Contains(vloggerName) && vloggers.Contains(followedUser) 
                        && vloggerName != followedUser && !followedNames[vloggerName].Contains(followedUser))
                    {
                        followedCount[vloggerName][0]++;
                        followedCount[followedUser][1]++;
                        followedNames[vloggerName].Add(followedUser);
                    }
                }
                command = Console.ReadLine();
            }
            string topName = "";
            int count = 0;
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            var topResult = followedCount.OrderByDescending(x => x.Value[1]).ThenBy(x=> x.Value[0]);
            foreach (var user in topResult)
            {
                count++;                
                Console.WriteLine($"{count}. {user.Key} : {user.Value[1]} followers, {user.Value[0]} following");
                if (count == 1)
                {
                    topName = user.Key;
                    var followers = followedNames.Where(x => x.Value.Contains(topName)).OrderBy(x => x.Key);
                    foreach (var follower in followers)
                    {
                        Console.WriteLine($"*  {follower.Key}");
                    }
                }
            }
        }
    }
}