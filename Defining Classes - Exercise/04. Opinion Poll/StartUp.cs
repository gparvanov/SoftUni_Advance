using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }
        public Person(int age) : this()
        {
            this.Name = "No name";
            this.Age = age;
        }
        public Person(string name, int age) : this(age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    public class Family
    {
        private Dictionary<string, int> people;
        public Dictionary<string, int> People
        {
            get { return people; }
            set { people = value; }
        }

        public void AddMember(Person person)
        {
            if (!People.ContainsKey(person.Name))
            {
                People[person.Name] = person.Age;
            }
        }
        public string GetOldestMember(Dictionary<string, int> People)
        {
            int maxAge = -1;
            string oldestName = "";
            foreach (var human in People)
            {
                if (human.Value > maxAge)
                {
                    maxAge = human.Value;
                    oldestName = human.Key;
                }
            }
            return oldestName;
        }
    }
}