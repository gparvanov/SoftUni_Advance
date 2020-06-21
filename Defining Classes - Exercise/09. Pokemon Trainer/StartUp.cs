using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainers
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int badges;

        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }

        private List<Pokemon> pokemon;

        public List<Pokemon> Pokemon
        {
            get { return pokemon; }
            set { pokemon = value; }
        }

        public Trainers(string name,int badges, List<Pokemon> pokemon)
        {
            this.Name = name;
            this.Badges = badges;
            this.Pokemon = pokemon;
        }
    }

    public class Pokemon
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string element;

        public string Element
        {
            get { return element; }
            set { element = value; }
        }

        private int health;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public Pokemon(string name,string element,int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }
    }
}
