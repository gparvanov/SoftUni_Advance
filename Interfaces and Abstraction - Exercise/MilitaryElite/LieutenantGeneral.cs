using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<Private> privatesList;
        public List<Private> PrivatesList
        {
            get => privatesList;
            private set
            {
                privatesList = value;
            }
        }
        public LieutenantGeneral (int id, string firstName, string lastName, decimal salary, List<Private> privates) 
            : base(id,firstName,lastName, salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.PrivatesList = new List<Private>();
            this.PrivatesList = privates;            
        }

        public override string ToString()
        {
            if (PrivatesList.Count > 0)
            {
                return $@"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}
Privates:
  {string.Join(Environment.NewLine + "  ", PrivatesList)}";
            }
            else
            {
                return $@"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}
Privates:";
            }
        }
    }
}