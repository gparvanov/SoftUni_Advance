using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Rabbits
{
    public class Rabbit
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string species;

        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        public bool available;

        public bool Available
        {
            get { return available; }
            set { available = value; }
        }

        public Rabbit(string name, string species)
        {
            this.Name = name;
            this.Species = species;
            this.Available = true;
        }

        public override string ToString()
        {            
            return $"Rabbit ({Species}): {Name}";
        }
    }

    public class Cage
    {
        private List<Rabbit> data;            
          
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;            
            data = new List<Rabbit>();
        }

        public int Count
        {
            get { return data.Count; }
        }

        public void Add(Rabbit rabbit)
        {
            if (data.Count < Capacity) data.Add(rabbit);
        }
        
        public void RemoveSpecies(string species)
        {
            foreach (var rabbit in data)
            {
                if (rabbit.Species == species) data.Remove(rabbit);
            }
        }

        public Rabbit SellRabbit(string name)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Name == name)
                {
                    data[i].Available = false;
                    return data[i];
                }
            }
            return null;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            List<Rabbit> tempList = new List<Rabbit>();
            for (int i = 0; i < data.Count; i++)
            {
                if(data[i].Species == species)
                {
                    data[i].Available = false;
                    tempList.Add(data[i]);
                }
            }
            return tempList.ToArray();
        }
        public bool RemoveRabbit(string name)
        {
            foreach (var rabbit in data)
            {
                if (rabbit.Name == name)
                {
                    data.Remove(rabbit);
                    return true;
                }
            }
            return false;
        }
        public string Report()
        {            
            string toReturn = $@"Rabbits available at {Name}:
{string.Join(Environment.NewLine, data.Where(x => x.Available==true))}";
            return toReturn;
        }
    }
}