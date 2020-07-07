using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set 
            {
                if(value.Length == 0 || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        private double money; 
        public double Money 
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        public List<string> Bag { get; set; }

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Bag = new List<string>();
        }
    }
}
