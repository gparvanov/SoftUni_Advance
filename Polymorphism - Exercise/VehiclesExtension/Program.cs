using System;

namespace VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine().Split();
            double carFuelQuantity = double.Parse(carInput[1]);
            double carLiterPerKm = double.Parse(carInput[2]);
            double carTankCapacity = double.Parse(carInput[3]);
            string[] truckInput = Console.ReadLine().Split();
            double truckFuelQuantity = double.Parse(truckInput[1]);
            double truckLiterPerKm = double.Parse(truckInput[2]);
            double truckTankCapacity = double.Parse(truckInput[3]);
            string[] busInput = Console.ReadLine().Split();
            double busFuelQuantity = double.Parse(busInput[1]);
            double busLiterPerKm = double.Parse(busInput[2]);
            double busTankCapacity = double.Parse(busInput[3]);

            Car car = new Car(carFuelQuantity, carLiterPerKm, carTankCapacity);
            Truck truck = new Truck(truckFuelQuantity, truckLiterPerKm, truckTankCapacity);
            Bus bus = new Bus(busFuelQuantity,busLiterPerKm,busTankCapacity);

            int commandsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNumber; i++)
            {
                string[] commandInput = Console.ReadLine().Split();
                if (commandInput[0] == "Drive")
                {
                    double distance = double.Parse(commandInput[2]);
                    if (commandInput[1] == "Car")
                    {
                        car.Drive(distance);
                    }
                    else if (commandInput[1] == "Truck")
                    {
                        truck.Drive(distance);
                    }
                    else if (commandInput[1] == "Bus")
                    {
                        bus.Drive(distance);
                    }
                }
                else if (commandInput[0] == "Refuel")
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
                    else if (commandInput[1] == "Bus")
                    {
                        bus.Refuel(liters);
                    }
                }
                else if ( commandInput[0] == "DriveEmpty")
                {
                    double distance = double.Parse(commandInput[2]);
                    bus.DriveEmpty(distance);
                }

            }
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}