using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public class Citizen : IPerson, IResident
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
        private string country;
        public string Country
        {
            get => country;
            set
            {
                country = value;
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

        public Citizen(string name,string country,int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }
        string IPerson.GetName()
        {
            return $"{this.Name}";
        }
        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }        
    }
}