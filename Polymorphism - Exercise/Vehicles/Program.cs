using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine().Split();
            double carFuelQuantity = double.Parse(carInput[1]);
            double carLiterPerKm = double.Parse(carInput[2]);
            string[] truckInput = Console.ReadLine().Split();
            double truckFuelQuantity = double.Parse(truckInput[1]);
            double truckLiterPerKm = double.Parse(truckInput[2]);

            Car car = new Car(carFuelQuantity, carLiterPerKm);
            Truck truck = new Truck(truckFuelQuantity, truckLiterPerKm);

            int commandsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNumber; i++)
            {
                string[] commandInput = Console.ReadLine().Split();
               if(commandInput[0] == "Drive")
                {
                    double distance = double.Parse(commandInput[2]);
                    if(commandInput[1] == "Car")
                    {
                        car.Drive(distance);
                    }
                    else if (commandInput[1] == "Truck")
                    {
                        truck.Drive(distance);
                    }
                }
               else if ( commandInput[0] == "Refuel")
                {
                    double liters = double.Parse(commandInput[2]);
                    if (commandInput[1] == "Car")
                    {
                        car.Refuel(liters);
                    }
                    else if (commandInput[1] == "Truck")
                    {
                        truck.Refuel(liters);
                    }
                }
                
            }
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}