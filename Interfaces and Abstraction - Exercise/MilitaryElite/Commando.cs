using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private Dictionary<string, string> missions;
        public Dictionary<string,string> Missions
        {
            get => missions;
            private set
            {
                missions = value;
            }
        }

        public Commando(int id, string firstName,string lastName,decimal salary, string corps, Dictionary<string,string> missions) 
            : base(id,firstName,lastName,salary,corps)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Corps = corps;
            this.Missions = new Dictionary<string, string>();
            this.Missions = missions;
        }
        public void CompleteMission(string MissionName)
        {
            if (Missions.ContainsKey(MissionName)) Missions[MissionName] = "Finished";
        }
        public override string ToString()
        {
            if (Missions.Count > 0)
            {
                return $@"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}
Corps: {this.Corps}
Missions:
  {string.Join(Environment.NewLine + "  ", Missions.Select(x => "Code Name: " + x.Key + " State: " + x.Value).ToArray())}";
            }
            else
            {
                return $@"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}
Corps: {this.Corps}
Missions:";
            }
        }
    }
}
