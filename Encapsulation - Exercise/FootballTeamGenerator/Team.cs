using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string teamName;

        public string TeamName
        {
            get => teamName;
            private set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.teamName = value; 
            }
        }

        private List<Player> players;

        public Team(string name)
        {
            this.TeamName = name;
            players = new List<Player>();
        }
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string player)
        {
            bool deleted = false;
            foreach (var entry in players)
            {
                if (entry.PlayerName.ToLower() == player.ToLower())
                {
                    players.Remove(entry);
                    deleted = true;
                    break;
                }
            }
            if(!deleted) Console.WriteLine($"Player {player} is not in {this.TeamName} team.");
        }

        public int Rating()
        {
            int count = players.Count;
            if (count>0)
            {
                double sum = 0;
                foreach (var person in players)
                {
                    sum += (person.Endurance + person.Sprint + person.Dribble + person.Passing + person.Shooting) / 5.0;
                }
                return (int)Math.Round(sum / count);
            }
            else return 0;
        }
    }
}