using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = Console.ReadLine();
            person.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {person.Name} \nAge: {person.Age}");


        }
    }
}
