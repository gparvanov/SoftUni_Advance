using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        private double wingSize;
        public override double WingSize
        {
            get => wingSize;
            set
            {
                wingSize = value;
            }
        }
        private string name;
        public override string Name
        { 
            get => name;
            set
            {
                name = value;
            }
        
        }
        private double weight;
        public override double Weight
        {
            get => weight;
            set
            {
                weight = value;
            }
        }
        private int foodEaten;
        public override int FoodEaten
        {
            get => foodEaten;
            set
            {
                foodEaten = value;
            }
        }

        public Owl(string name, double weight, double wingSize)
        {
            this.Name = name;
            this.Weight = weight;
            this.WingSize = wingSize;
        }
        public override void FeedAnimal(string type, int quantity)
        {
            if (type != "Meat") Console.WriteLine($"{this.GetType().Name} does not eat {type}!");
            else
            {
                this.Weight += quantity * 0.25;
                this.FoodEaten += quantity;
            }
        }

        public override string MakeSound()
        {
            return "Hoot Hoot";
        }        
    }
}
