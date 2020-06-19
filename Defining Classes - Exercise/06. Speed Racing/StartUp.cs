using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private double fuelAmount;

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        private double fuelConsumptionPerKilometer;

        public double FuelConsumptionPerKilometer
        {
            get { return fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }
        }

        private double travelledDistance;

        public double TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }

        public Car (string model, double fuelAmount, double fuelConsumptionPerKilometer, double Travelleddistance)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = Travelleddistance;
        }

        public static void Drive(Car[] carList, string carModel, int amountOfKm)
        {
            foreach (var car in carList)
            {
                if(car.Model == carModel)
                {
                    double consumation = car.fuelConsumptionPerKilometer * amountOfKm;
                    if (car.FuelAmount >= consumation)
                    {
                        car.FuelAmount -= consumation;
                        car.TravelledDistance += amountOfKm;
                    }
                    else Console.WriteLine("Insufficient fuel for the drive");
                }
            }            
        }
    }
}
