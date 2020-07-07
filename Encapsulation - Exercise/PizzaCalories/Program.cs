namespace PizzaCalories
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {          
            try
            {
                string[] pizzaArgs = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string pizzaName = pizzaArgs[1];

                string[] doughArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string doughFlourTypes = doughArgs[1];
                string doughBakingTechniques = doughArgs[2];
                double weight = double.Parse(doughArgs[3]);
                Dough dough = new Dough(doughFlourTypes, doughBakingTechniques, weight);
                
                Pizza pizza = new Pizza(pizzaName, dough);
                
                string inputLine = Console.ReadLine();
                
                while(inputLine != "END")
                {                    
                    string[] toppingArgs = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string toppingType = toppingArgs[1];
                    double weightTopping = double.Parse(toppingArgs[2]);

                    Topping topping = new Topping(toppingType, weightTopping);

                    pizza.AddTopping(topping);

                    inputLine = Console.ReadLine();
                }
                Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories().ToString("f2")} Calories.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
