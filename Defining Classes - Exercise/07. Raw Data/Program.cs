using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] dataParts = Console.ReadLine().Split();
                string model = dataParts[0];
                int engineSpeed = int.Parse(dataParts[1]);
                int enginePower = int.Parse(dataParts[2]);
                int cargoWeight = int.Parse(dataParts[3]);
                string cargoType = dataParts[4];
                double tire1Pressure = double.Parse(dataParts[5]);
                int tire1Age = int.Parse(dataParts[6]);
                double tire2Pressure = double.Parse(dataParts[7]);
                int tire2Age = int.Parse(dataParts[8]);
                double tire3Pressure = double.Parse(dataParts[9]);
                int tire3Age = int.Parse(dataParts[10]);
                double tire4Pressure = double.Parse(dataParts[11]);
                int tire4Age = int.Parse(dataParts[12]);
                Tire[] tires = new Tire[4]
                {
                    new Tire(tire1Pressure,tire1Age),
                    new Tire(tire2Pressure,tire2Age),
                    new Tire(tire3Pressure,tire3Age),
                    new Tire(tire4Pressure,tire4Age),
                };
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car currentCar = new Car(model,engine,cargo,tires);
                cars.Add(currentCar);

            }
            string filter = Console.ReadLine();

            foreach (var piece in cars)
            {
                if(filter == "flamable")
                {
                    if(piece.Cargo.CargoType == "flamable" && piece.Engine.EnginePower> 250) Console.WriteLine($"{piece.Model}");
                }
                else if (filter == "fragile")
                {
                    if (piece.Cargo.CargoType == "fragile")
                    {
                        foreach (var tire in piece.Tires)
                        {
                            if(tire.Pressure <1)
                            {
                                Console.WriteLine($"{piece.Model}");
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
