using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Family currentFamily = new Family();
            currentFamily.People = new Dictionary<string, int>();
            for (int i = 0; i < rows; i++)
            {
                string[] data = Console.ReadLine().Split();
                string name = data[0];
                int age = int.Parse(data[1]);

                Person currentPerson = new Person(name, age);
                currentFamily.AddMember(currentPerson);
            }            
            var result = currentFamily.People
                .Where(x => x.Value > 30)
                .OrderBy(x => x.Key);

            foreach (var human in result)
            {
                Console.WriteLine($"{human.Key} - {human.Value}");
            }
        }
    }
}