﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }
}
