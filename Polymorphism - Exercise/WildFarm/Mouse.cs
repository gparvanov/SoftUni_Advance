using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        private string livingRegion;
        public override string LivingRegion 
        { 
            get => livingRegion; 
            set
            {
                livingRegion = value;
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
        public Mouse(string name, double weight, string livingRegion)
        {
            this.Name = name;
            this.Weight = weight;
            this.LivingRegion = livingRegion;
        }

        public override void FeedAnimal(string type, int quantity)
        {
            if (type != "Vegetable" && type!="Fruit") Console.WriteLine($"{this.GetType().Name} does not eat {type}!");
            else
            {
                this.Weight += quantity * 0.1;
                this.FoodEaten += quantity;
            }
        }

        public override string MakeSound()
        {
            return "Squeak";
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}