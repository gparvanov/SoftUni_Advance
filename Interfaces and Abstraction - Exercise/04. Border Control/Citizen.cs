using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control
{
    public class Citizen : Creature
    {
        private string name;

        public string Name
        {
            get => name;
            set 
            { 
                name = value; 
            }
        }

        private int age;

        public int Age
        {
            get => age;
            set 
            { 
                age = value; 
            }
        }

        public string Id { get; set; }

        public Citizen(string name, int age, string id) 
        {
            this.Name = name;
            this.Age = age;
            this.Id = id; 
        }
    }
}
