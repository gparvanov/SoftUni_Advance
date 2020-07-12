using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizen : ICreature, IRobot
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

        public string Birthday { get; set; }

        public void HaveBirthday(string year)
        {
            if (this.Birthday.EndsWith(year)) Console.WriteLine(this.Birthday);
        }

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
        }
    }
}