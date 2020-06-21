using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int engines = int.Parse(Console.ReadLine());
            List<Engine> enginesDB = new List<Engine>();
            for (int i = 0; i < engines; i++)
            {
                string[] dataInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = dataInput[0];
                int power = int.Parse(dataInput[1]);
                string displacement = "n/a";
                string efficiency = "n/a";
                bool isNumeric = false;
                if (dataInput.Length > 2)
                {
                    isNumeric = int.TryParse(dataInput[2], out _);
                    if (isNumeric)
                    {
                        displacement = dataInput[2];
                        if (dataInput.Length > 3)  efficiency  = dataInput[3];
                    }
                    else efficiency = dataInput[2];
                }
                Engine engine = new Engine(model, power, displacement, efficiency);
                enginesDB.Add(engine);
            }
            int cars = int.Parse(Console.ReadLine());
            List<Car> carsDB = new List<Car>();
            for (int i = 0; i < cars; i++)
            {
                string[] dataInput = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = dataInput[0];                
                string weight = "n/a";
                string color = "n/a";                
                bool isNumeric = false;
                if (dataInput.Length > 2)
                {
                    isNumeric = int.TryParse(dataInput[2], out _);
                    if (isNumeric)
                    {
                        weight = dataInput[2];
                        if(dataInput.Length>3) color = dataInput[3];
                    }
                    else color = dataInput[2];                    
                }
                foreach (var engine in enginesDB)
                {
                    if(engine.Model == dataInput[1])
                    {
                        Car currentCar = new Car(model, engine, weight, color);
                        carsDB.Add(currentCar);
                        break;
                    }
                }
            }
            foreach (var car in carsDB)
            {
                Console.WriteLine($"{car.Model}:");                
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");                
            }
        }
    }
}