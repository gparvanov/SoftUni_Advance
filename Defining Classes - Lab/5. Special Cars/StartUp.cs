using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private double fuelQuantity;
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        private double fuelConsumption;
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
        private Engine engine;
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        private Tire[] tires;
        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }
        public Car()
        {
            
        }
        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,
            Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public void Drive(double distance)
        {
            double remainFuel = FuelQuantity - (distance * FuelConsumption) / 100.0;
            if (remainFuel >= 0) FuelQuantity = remainFuel;
            //else Console.WriteLine("Not enough fuel to perform this trip!");
        }        
    }
    public class Engine
    {
        private int horsePower;
        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }
        private double cubicCapacity;
        public double CubicCapacity
        {
            get { return cubicCapacity; }
            set { cubicCapacity = value; }
        }
        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
    }
    public class Tire
    {
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private double pressure;

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }
        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
}