using System;

namespace Operations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            MathOperations oper = new MathOperations();
            Console.WriteLine(oper.Add(2, 3));
            Console.WriteLine(oper.Add(2.2, 3.3, 5.5));
            Console.WriteLine(oper.Add(2.2m, 3.3m, 4.4m));
        }
    }
}