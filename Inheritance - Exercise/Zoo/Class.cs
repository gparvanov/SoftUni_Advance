using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal (string name)
        {
            this.Name = name;
        }
    }

    public class Reptile : Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Reptile ( string name) : base(name)
        {
            this.Name = name;
        }
    }

    public class Lizard : Reptile
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Lizard(string name) : base(name)
        {
            this.Name = name;
        }
    }
    public class Snake : Reptile
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Snake(string name) : base(name)
        {
            this.Name = name;
        }
    }
    public class Mammal : Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Mammal(string name) : base(name)
        {
            this.Name = name;
        }
    }

    public class Gorilla : Mammal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Gorilla(string name) : base(name)
        {
            this.Name = name;
        }
    }
    public class Bear : Mammal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Bear(string name) : base(name)
        {
            this.Name = name;
        }
    }
}
