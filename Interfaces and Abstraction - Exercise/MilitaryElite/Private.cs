using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Private : Soldier, IPrivate
    {
        private decimal salary;
        public decimal Salary 
        {
            get => salary;
            protected set
            {
                salary = value;
            }
        }        
        public Private(int id, string firstName, string lastName, decimal salary) 
            : base(id,firstName, lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;            
            this.Salary = salary;
        }
        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}";
        }
    }
}