using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Car : Vehicle
    {
        private double fuelQuantity;
        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (value > this.TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else fuelQuantity = value;
            }
        }
        private double fuelConsumption;
        public double FuelConsumption
        {
            get => fuelConsumption;
            set
            {
                fuelConsumption = value;
            }
        }
        private double tankCapacity;
        public double TankCapacity
        {
            get => tankCapacity;
            set
            {
                tankCapacity = value;
            }
        }

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;            
        }

        public void Drive(double distance)
        {
            double summerConsumption = 0.9 + this.FuelConsumption;
            if (this.FuelQuantity >= (distance * summerConsumption))
            {
                this.FuelQuantity -= (distance * summerConsumption);
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }
        public void Refuel(double liters)
        {
            if (liters > 0)
            {
                if (this.TankCapacity - FuelQuantity < liters)
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    this.FuelQuantity += liters;
                }
            }
            else
            {
                Console.WriteLine("Fuel must be a positive number");
            }
        }
    }
}
