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
        private Engine engine;
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        private string weight;
        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Car(string model,Engine engine, string weight = "n/a", string color = "n/a")
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }
    }
    public class Engine
    {
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int power;
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        private string displacement;
        public string Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }
        private string efficiency;
        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }
        public Engine(string model,int power,string displacement = "n/a", string efficiency = "n/a")
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
    }
}
