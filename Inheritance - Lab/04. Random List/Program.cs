using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var randomList = new RandomList();

            randomList.Add("Ivan");
            randomList.Add("Pesho");
            randomList.Add("Gosho");

            Console.WriteLine(randomList.RandomString());

            
        }
    }
}
