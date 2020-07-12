using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private Dictionary<string, int> repairs;
        public Dictionary<string,int> Repairs
        {
            get => repairs; 
            private set
            {                
                repairs = value;              
            }
        }
        public Engineer(int id, string firstName, string lastName, decimal salary, string corps, Dictionary<string,int> repairs) 
            : base (id, firstName, lastName, salary, corps)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Corps = corps;
            this.Repairs = new Dictionary<string, int>();
            this.Repairs = repairs; 
        }

        public override string ToString()
        {
            if (Repairs.Count > 0)
            {
                return $@"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}
Corps: {this.Corps}
Repairs:
  {string.Join(Environment.NewLine + "  ", Repairs.Select(x => "Part Name: " + x.Key + " Hours Worked: " + x.Value).ToArray())}";
            }
            else
            {
                return $@"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}
Corps: {this.Corps}
Repairs:";
            }
        }
    }
}