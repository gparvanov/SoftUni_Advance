using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        private int food;
        public int Food 
        {
            get => food;
            set 
            {
                food = value;
            }
        }

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

        private string group;

        public string Group
        {
            get => group;
            set 
            { 
                group = value; 
            }
        }

        public void BuyFood()
        {
            this.Food += 5;
        }

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            Food = 0;
        }
    }
}