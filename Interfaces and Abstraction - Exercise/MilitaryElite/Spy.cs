using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Spy : Soldier, ISpy
    {
        private int codeNumber;  
        public int CodeNumber 
        {
            get => codeNumber;
            private set
            {
                codeNumber = value;
            }
        }

        public Spy(int id, string firstName, string lastName, int codeNumber) : base (id, firstName, lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            return $@"Name: {this.FirstName} {this.LastName} Id: {this.Id}
Code Number: {this.CodeNumber}";
        }
    }
}
