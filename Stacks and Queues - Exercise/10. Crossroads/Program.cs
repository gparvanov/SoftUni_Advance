using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string command = Console.ReadLine();
            bool crashHappened = false;
            int passedCars = 0;
            string car = "";
            char charHit = ' ';
            while (command != "END")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else if (command == "green")
                {
                    int leftTime = greenDuration + freeWindowDuration;
                    while (leftTime > 0 && cars.Count !=0)
                    {
                        string currentCar = cars.Dequeue();
                        passedCars++;
                        int consumingTime = currentCar.Length;
                        leftTime -= consumingTime;
                        if (leftTime < 0)
                        {
                            crashHappened = true;
                            int hitterChar = ( leftTime * -1 );
                            car = currentCar;
                            charHit = car[car.Length - hitterChar];                            
                            break;
                        }
                        else if (leftTime >= 0 && leftTime <= freeWindowDuration ) break;                        
                    }                    
                }
                if (crashHappened) break;
                command = Console.ReadLine();
            }
            if (!crashHappened)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }
            else
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{car} was hit at {charHit}.");
            }
        }
    }
}