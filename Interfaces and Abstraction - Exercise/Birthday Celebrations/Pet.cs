using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet : ICreature
    {
        private string birthday;
        
        public string Birthday { get; set; }

        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }

        public void HaveBirthday(string year)
        {
            if (this.Birthday.EndsWith(year)) Console.WriteLine(this.Birthday);
        }

        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
    }
}