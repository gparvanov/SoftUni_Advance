using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public double DefaultFuelConsumption = 1.25;        

        public virtual double FuelConsumption { get; set; }

        private double fuel;

        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        private int horsePower;

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

        public Vehicle (int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public virtual void Drive(double kilometers)
        {
            Fuel -= (kilometers * DefaultFuelConsumption);
        }
    }

    public class Motorcycle : Vehicle
    { 
        public Motorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
        public virtual void Drive(double kilometers)
        {
            this.Fuel -= (kilometers * DefaultFuelConsumption);
        }
    }

    public class Car : Vehicle
    {
        public double DefaultFuelConsumption = 3;
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
        public virtual void Drive(double kilometers)
        {
            this.Fuel -= (kilometers * DefaultFuelConsumption);
        }
    }

    public class RaceMotorcycle : Motorcycle
    {        
        public double DefaultFuelConsumption = 8;             
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
        public virtual void Drive(double kilometers)
        {
            this.Fuel -= (kilometers * DefaultFuelConsumption);
        }
    }
    public class CrossMotorcycle : Motorcycle
    {        
        public CrossMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
        public virtual void Drive(double kilometers)
        {
            this.Fuel -= (kilometers * DefaultFuelConsumption);
        }
    }
    public class FamilyCar : Car
    {
        public FamilyCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
        public virtual void Drive(double kilometers)
        {
            this.Fuel -= (kilometers * DefaultFuelConsumption);
        }
    }

    public class SportCar : Car
    {      
        public double DefaultFuelConsumption = 10;
                       
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
        public virtual void Drive(double kilometers)
        {
            this.Fuel -= (kilometers * DefaultFuelConsumption);
        }
    }
}