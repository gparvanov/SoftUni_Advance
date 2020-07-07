using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Team> teams = new List<Team>();
            while (input != "END")
            {
                try
                {
                    string[] dataArgs = input.Split(";");
                    if (dataArgs[0].ToLower() == "team")
                    {
                        string teamName = dataArgs[1];
                        Team team = new Team(teamName);
                        teams.Add(team);
                    }
                    else if(dataArgs[0].ToLower() == "rating")
                    {
                        string teamName = dataArgs[1];
                        bool found = false;
                        foreach (var team in teams)
                        {
                            if(team.TeamName == teamName)
                            {
                                Console.WriteLine($"{team.TeamName} - {team.Rating()}");
                                found = true;
                                break;
                            }
                        }
                        if (!found) Console.WriteLine($"Team {teamName} does not exist.");
                    }
                    else if (dataArgs[0].ToLower() == "add")
                    {
                        string teamName = dataArgs[1];
                        string playerName = dataArgs[2];
                        int endurance = int.Parse(dataArgs[3]);
                        int sprint = int.Parse(dataArgs[4]);
                        int dribble = int.Parse(dataArgs[5]);
                        int passing = int.Parse(dataArgs[6]);
                        int shooting = int.Parse(dataArgs[7]);
                        bool added = false;
                        foreach (var team in teams)
                        {
                            if (team.TeamName == teamName)
                            {
                                Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);                                
                                team.AddPlayer(player);
                                added = true;
                                break;
                            }                            
                        }
                        if(!added) Console.WriteLine($"Team {teamName} does not exist.");
                    }
                    else if ( dataArgs[0].ToLower() == "remove")
                    {
                        string teamName = dataArgs[1];
                        string playerName = dataArgs[2];                        
                        foreach (var team in teams)
                        {
                            if (team.TeamName == teamName)
                            {
                                team.RemovePlayer(playerName);
                                break;
                            }
                        }                        
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                input = Console.ReadLine();
            }
        }
    }
}
