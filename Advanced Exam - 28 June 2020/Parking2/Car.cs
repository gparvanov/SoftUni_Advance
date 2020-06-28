using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Parking
{
    public class Car
    {
        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
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

        public Car(string manufacturer,string model,int year)
        {
            this.Manufacturer = manufacturer.Trim();
            this.Model = model.Trim();
            this.Year = year;
        }

        public override string ToString()
        {
            return $"{this.Manufacturer} {this.Model} ({this.Year})";
        }

    }

    public class Parking
    {
        private List<Car> data;

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int Count
        {
            get { return data.Count; }
        }
        public Parking(string type,int capacity)
        {
            this.Type = type.Trim();
            this.Capacity = capacity;
            data = new List<Car>();
        }

        public void Add(Car car)
        {
            if (data.Count < Capacity) data.Add(car);
        }

        public bool Remove(string manufacturer, string model)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Manufacturer == manufacturer && data[i].Model == model)
                {
                    data.RemoveAt(i);
                    return true;
                }
                
            }
            return false;
        }

        public Car GetLatestCar()
        {
            var result = data.OrderByDescending(x => x.Year);
            foreach (var item in result)
            {
                return item;
            }
            return null;
        }

        public Car GetCar(string manufacturer, string model)
        {
            foreach (var item in data)
            {
                if(item.Manufacturer == manufacturer && item.Model == model)
                {
                    return item;
                }
            }
            return null;
        }

        public string GetStatistics()
        {
            return $@"The cars are parked in {Type}:
{string.Join(Environment.NewLine,data)}";
        }
    }
}
