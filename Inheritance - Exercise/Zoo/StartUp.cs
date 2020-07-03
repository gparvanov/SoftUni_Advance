using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Animal ani = new Animal(Console.ReadLine());

            Lizard liz = new Lizard(Console.ReadLine());

            Console.WriteLine(ani.Name);
            Console.WriteLine(liz.Name);
        }
    }
}