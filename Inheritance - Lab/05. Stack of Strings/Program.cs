using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tempStack = new StackOfStrings();

            Console.WriteLine(tempStack.IsEmpty());

            string[] tinyArray = new string[]
            {
                "Pesho",
                "Gosho",
                "Stefan",
                "Ivan"
            };
            tempStack.AddRange(tinyArray);
            //Console.WriteLine(string.Join(", ", tempStack));
            //Console.WriteLine(tempStack.IsEmpty());
        }
    }
}