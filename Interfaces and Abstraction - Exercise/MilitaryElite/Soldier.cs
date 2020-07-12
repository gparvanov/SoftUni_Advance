using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Soldier : ISoldier
    {
        private int id;
        public int Id 
        { 
            get => id;
            set 
            { 
                id = value; 
            }
        }
        private string firstName;
        public string FirstName 
        {
            get => firstName; 
            set
            {
                firstName = value;
            }
        }
        private string lastName; 
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
            }
        }
        public Soldier( int id, string firstName, string lastName )
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}