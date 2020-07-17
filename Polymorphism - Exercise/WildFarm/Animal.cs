using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }

        public abstract double Weight { get; set;  }

        public abstract int FoodEaten { get; set;  }

        public abstract void FeedAnimal(string type, int quantity);

        public abstract string MakeSound();
    }
}