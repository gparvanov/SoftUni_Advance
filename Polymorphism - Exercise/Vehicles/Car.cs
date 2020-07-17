using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private double fuelQuantity;
        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            { 
                fuelQuantity = value; 
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

        public Car(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public void Drive(double distance)
        {
            double summerConsumption = 0.9 + this.FuelConsumption;
            if(this.FuelQuantity >= (distance * summerConsumption))
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
            this.FuelQuantity += liters;
        }
    }
}
