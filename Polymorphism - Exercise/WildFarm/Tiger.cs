using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {
        private string breed;
        public override string Breed
        {
            get => breed;
            set
            {
                breed = value;
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
        private string livingRegion;
        public override string LivingRegion
        {
            get => livingRegion;
            set
            {
                livingRegion = value;
            }
        }
        public Tiger(string name, double weight, string livingRegion, string breed)
        {
            this.Name = name;
            this.Weight = weight;
            this.LivingRegion = livingRegion;
            this.Breed = breed;
        }
        public override void FeedAnimal(string type, int quantity)
        {
            if (type != "Meat") Console.WriteLine($"{this.GetType().Name} does not eat {type}!");
            else
            {
                this.Weight += quantity * 1.0;
                this.FoodEaten += quantity;
            }
        }

        public override string MakeSound()
        {
            return "ROAR!!!";
        }
    }
}
