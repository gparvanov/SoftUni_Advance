using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Christmas
{
    public class Present
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public override string ToString()
        {
            return $"Present {this.Name} ({this.Weight}) for a {this.Gender}";            
        }

        public Present(string name , double weight, string gender)
        {
            this.Name = name;
            this.Weight = weight;
            this.Gender = gender;
        }
    }

    public class Bag
    {
        List<Present> data = new List<Present>();
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Bag (string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            data = new List<Present>();
        }

        public void Add ( Present present)
        {
            if (data.Count < Capacity) data.Add(present);
        }
        public int Count
        {
            get { return data.Count; }            
        }

        public bool Remove(string name)
        {
            bool successfully = false;

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Name == name) data.RemoveAt(i);
                return true;
            }
            return successfully;
        }

        public Present GetHeaviestPresent()
        {
            var getHeaviest = data.OrderByDescending(x => x.Weight);            
            foreach (var item in getHeaviest)
            {
                return item;
            }
            return null;
        }

        public Present GetPresent(string name)
        {
            foreach (var present in data)
            {
                if (present.Name == name) return present;
            }
            return null;
        }

        public string Report()
        {
            string toReturn = "";
            toReturn = $@"{Color} bag contains:
{string.Join(Environment.NewLine,data)}";
            return toReturn;
        }
    }
}