using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Person person = new Person();
            Person person2 = new Person(age);
            Person person3 = new Person(name, age);
        }
    }
}