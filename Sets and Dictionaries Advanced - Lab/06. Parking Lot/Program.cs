using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();
            string command = Console.ReadLine();

            while(command != "END")
            {
                string[] data = command.Split(", ");
                string direction = data[0];
                string carNumber = data[1];
                if (direction == "IN") carNumbers.Add(carNumber);
                else if (direction == "OUT" && carNumbers.Contains(carNumber)) carNumbers.Remove(carNumber);
                command = Console.ReadLine();
            }
            if(carNumbers.Count>0 ) Console.WriteLine(string.Join(Environment.NewLine,carNumbers));
            else Console.WriteLine("Parking Lot is Empty");
        }
    }
}