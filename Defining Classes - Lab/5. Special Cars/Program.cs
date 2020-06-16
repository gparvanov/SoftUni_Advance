using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {            
            string command = Console.ReadLine();
            Dictionary<int, Tire[]> tiresDB= new Dictionary<int, Tire[]>();
            int tiresCounter = -1;
            while (command != "No more tires")
            {
                tiresCounter++;
                string[] tires = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                int tire1Index = int.Parse(tires[0]);
                double tire1Pressure = double.Parse(tires[1]);
                int tire2Index = int.Parse(tires[2]);
                double tire2Pressure = double.Parse(tires[3]);
                int tire3Index = int.Parse(tires[4]);
                double tire3Pressure = double.Parse(tires[5]);
                int tire4Index = int.Parse(tires[6]);
                double tire4Pressure = double.Parse(tires[7]);
                                
                tiresDB[tiresCounter] = new Tire[4]
                {
                    new Tire(tire1Index,tire1Pressure),
                    new Tire(tire2Index,tire2Pressure),
                    new Tire(tire3Index,tire3Pressure),
                    new Tire(tire4Index,tire4Pressure),
                };
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            Dictionary<int, Engine> engineDB = new Dictionary<int, Engine>();
            int engineCounter = -1;
            while (command != "Engines done")
            {
                engineCounter++;
                string[] commandData = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horseP = int.Parse(commandData[0]);
                double cubicC = double.Parse(commandData[1]);
                engineDB[engineCounter] = new Engine(horseP, cubicC);
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            List<Car> carsList = new List<Car>();
            while (command!="Show special")
            {
                string[] commandData = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = commandData[0];
                string model = commandData[1];
                int year = int.Parse(commandData[2]);
                double fuelQuantity = double.Parse(commandData[3]);
                double fuelConsumption = double.Parse(commandData[4]);
                int engineIndex = int.Parse(commandData[5]);
                int tireIndex = int.Parse(commandData[6]);
                var engine = engineDB[engineIndex];
                var tires = tiresDB[tireIndex];
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);
                carsList.Add(car);                
                command = Console.ReadLine();
            }
            foreach (var carIndex in carsList)
            {                
                if (carIndex.Year >= 2017 && carIndex.Engine.HorsePower >= 330)
                {
                    double tirePressure = 0;
                    foreach (var tire in carIndex.Tires)
                    {
                        tirePressure += tire.Pressure;
                    }
                    if (tirePressure > 9 && tirePressure < 10)
                    {
                        carIndex.Drive(20);
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine($"Make: {carIndex.Make}");
                        sb.AppendLine($"Model: {carIndex.Model}");
                        sb.AppendLine($"Year: {carIndex.Year}");
                        sb.AppendLine($"HorsePowers: {carIndex.Engine.HorsePower}");
                        sb.Append($"FuelQuantity: {carIndex.FuelQuantity}L");
                        Console.WriteLine(sb.ToString());
                    }
                }                
            }
        }
    }
}