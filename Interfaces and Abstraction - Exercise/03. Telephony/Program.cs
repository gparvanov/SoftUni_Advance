using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            foreach (var number in phoneNumbers)
            {
                bool onlyDigits = number.All(char.IsDigit);
                Smartphone smartphone = new Smartphone();
                StationaryPhone stationaryPhone = new StationaryPhone();
                if (onlyDigits && number.Length == 10)
                {
                    Console.WriteLine(smartphone.Call(number));
                }
                else if (onlyDigits && number.Length == 7)
                {
                    Console.WriteLine(stationaryPhone.Dial(number));
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            foreach (var site in sites)
            {
                bool hasDigit = false;
                foreach (var symbol in site)
                {
                    if (symbol >= '0' && symbol <= '9')
                    {
                        hasDigit = true;
                        break;
                    }
                }
                if (hasDigit)
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    Smartphone smartphone = new Smartphone();
                    Console.WriteLine(smartphone.Browse(site));
                }
            }
        }
    }
}
