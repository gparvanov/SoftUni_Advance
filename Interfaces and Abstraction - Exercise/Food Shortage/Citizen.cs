using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Citizen : IBuyer
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

        private string birthday;

        public string Birthday
        {
            get => birthday;
            set 
            { 
                birthday = value; 
            }
        }

        private string id;

        public string Id
        {
            get => id;
            set 
            { 
                id = value; 
            }
        }

        public void BuyFood()
        {
            this.Food += 10;
        }

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
            Food = 0;
        }
    }
}