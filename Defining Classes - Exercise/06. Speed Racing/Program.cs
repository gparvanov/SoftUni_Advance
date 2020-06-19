using System;
using System.Collections.Generic;

namespace DefiningClasses

{
    class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Car[] carList = new Car[numberOfCars];            
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] dataInput = Console.ReadLine().Split();                
                string model = dataInput[0];
                double fuelAmmount = double.Parse(dataInput[1]);
                double fuelConsumptionPerKilometer = double.Parse(dataInput[2]);
                Car currentCar = new Car(model,fuelAmmount,fuelConsumptionPerKilometer,0);
                carList[i] = currentCar;
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandParts = command.Split();
                string carModel = commandParts[1];
                int ammountOfKm = int.Parse(commandParts[2]);
                Car.Drive(carList,carModel,ammountOfKm);
                command = Console.ReadLine();
            }

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}