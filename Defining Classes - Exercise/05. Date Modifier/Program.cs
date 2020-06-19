using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] date1 = Console.ReadLine().Split();
            string[] date2 = Console.ReadLine().Split();

            DateModifier date = new DateModifier();
            Console.WriteLine(Math.Abs(date.ComputeTimeSpanInDays(date1, date2)));            
        }
    }
}