using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombsEffects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Stack<int> bombsCasings = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));

            int daturaBombs = 0;
            int cherryBombs = 0;
            int smokeDecoyBombs = 0;

            while(bombsEffects.Count>0 && bombsCasings.Count > 0)
            {
                int bombEffect = bombsEffects.Peek();
                int bombCasing = bombsCasings.Peek();

                int sum = bombEffect + bombCasing;
                if (sum == 40)
                {
                    bombsEffects.Dequeue();
                    bombsCasings.Pop();
                    daturaBombs++;
                }
                else if (sum == 60)
                {
                    bombsEffects.Dequeue();
                    bombsCasings.Pop();
                    cherryBombs++;
                }
                else if (sum == 120)
                {
                    bombsEffects.Dequeue();
                    bombsCasings.Pop();
                    smokeDecoyBombs++;
                }
                else
                {
                    int tempValue = bombsCasings.Pop();
                    bombsCasings.Push(tempValue - 5);
                }
                if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3) break;
            }

            if(daturaBombs>=3 && cherryBombs>=3 && smokeDecoyBombs >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            if (bombsEffects.Count == 0) Console.WriteLine("Bomb Effects: empty");
            else Console.WriteLine($"Bomb Effects: {string.Join(", ",bombsEffects)}");
            if (bombsCasings.Count == 0) Console.WriteLine("Bomb Casings: empty");
            else Console.WriteLine($"Bomb Casings: {string.Join(", ", bombsCasings)}");

            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
        }
    }
}
