using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string @class;

        public string @Class
        {
            get { return @class; }
            set { @class = value; }
        }
        private string rank;

        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Player(string name, string @class)
        {
            this.Name = name;
            this.@Class = @class;
            this.Rank = "Trial";
            this.Description = "n/a";
        }
        public override string ToString()
        {
            string toReturn =
                @$"Player {this.Name}: {this.@Class}
Rank: {this.Rank}
Description: {this.Description}";
            return toReturn;
        }
    }

    public class Guild
    {
        private List<Player> roster;

        public List<Player> Roster 
        {
            get { return roster; }
            set { roster = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Guild(string name, int capacity) 
        {
            this.Name = name;
            this.Capacity = capacity;
            roster = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if(roster.Count< Capacity)
            {
                roster.Add(player);
            }
        }
        public int Count
        {
            get { return roster.Count; }            
        }
        public bool RemovePlayer( string name)
        {            
            for (int i = 0; i < roster.Count; i++)
            {
                if(roster[i].Name == name)
                {
                    roster.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public void PromotePlayer(string name)
        {
            foreach (var player in roster)
            {
                if (player.Name == name && player.Rank != "Member") player.Rank = "Member";
            }
        }
        public void DemotePlayer(string name)
        {
            foreach (var player in roster)
            {
                if (player.Name == name && player.Rank != "Trial") player.Rank = "Trial";                
            }
        }

        public Player[] KickPlayersByClass(string @class)
        {
            List<Player> tempList = new List<Player>();
            for (int i = 0; i < roster.Count; i++)
            {
                if (roster[i].@Class == @class)
                {                    
                    tempList.Add(roster[i]);
                    roster.RemoveAt(i);
                    if(roster.Count>0) i--;
                }
            }
            return tempList.ToArray();
        }

        public string Report()
        {
            string toReturn = $@"Players in the guild: {this.Name}
{string.Join(Environment.NewLine,roster)}";
            return toReturn;
        }
    }
}