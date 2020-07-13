using System;

namespace ExplicitInterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split();

            while(inputData[0] != "End")
            {
                string name = inputData[0];
                string country = inputData[1];
                int age = int.Parse(inputData[2]);

                IPerson citizen = new Citizen(name, country, age);
                IResident citizen2 = new Citizen(name, country, age);
                Console.WriteLine(citizen.GetName());
                Console.WriteLine(citizen2.GetName());

                inputData = Console.ReadLine().Split();
            }
        }
    }
}