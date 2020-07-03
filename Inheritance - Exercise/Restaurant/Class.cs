using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Product
    {
        public string Name  { get; set; }

        public decimal Price { get; set; }

        public Product( string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }

    public class Beverage : Product
    {
        public double Milliliters { get; set; }

        public Beverage ( string name, decimal price, double milliliters) : base ( name, price)
        {            
            this.Milliliters = milliliters;
        }
    }

    public class Food : Product
    {
        public double Grams { get; set; }
        public Food(string name, decimal price, double grams) : base(name, price)
        {            
            this.Grams = grams;
        }
    }

    public class HotBeverage : Beverage
    {
        public HotBeverage (string name, decimal price, double milliliters) : base (name,price, milliliters)
        {            
        }
    }
    public class ColdBeverage : Beverage
    {
        public ColdBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {            
        }
    }

    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliters = 50;
        private const decimal CoffeePrice = 3.5m;

        public double Caffeine { get; set; }

        public Coffee(string name, double caffeine ) : base ( name, CoffeePrice, CoffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }
    }
    public class Tea : HotBeverage
    {        
        public Tea(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {                      
        }
    }

    public class MainDish : Food
    {
        public MainDish(string name, decimal price, double grams) : base(name, price, grams)
        {            
        }
    }
    public class Dessert : Food
    {
        public double Calories { get; set; }
        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {            
            this.Calories = calories;
        }
    }
    public class Starter : Food
    {
        public Starter(string name, decimal price, double grams) : base(name, price, grams)
        {            
        }
    }
    public class Soup : Starter
    {
        public Soup(string name, decimal price, double grams) : base(name, price, grams)
        {            
        }
    }
    public class Cake : Dessert
    {
        private const double Grams = 250;
        private const double Calories = 1000;
        private const decimal CakePrice = 5m;
        public Cake(string name) : base(name, CakePrice, Grams,Calories)
        {            
        }
    }

    public class Fish : MainDish
    {
        private const double Grams = 22;
        public Fish(string name, decimal price) : base(name, price, Grams)
        {            
        }
    }
}