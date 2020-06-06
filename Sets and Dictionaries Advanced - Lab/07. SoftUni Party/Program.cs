using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            string command = Console.ReadLine();

            while(command != "PARTY")
            {
                bool isVip = char.IsDigit(char.Parse(command.Substring(0, 1)));
                if (isVip) vipGuests.Add(command);
                else regularGuests.Add(command);
                command = Console.ReadLine();
            }
            while(command != "END")
            {
                bool isVip = char.IsDigit(char.Parse(command.Substring(0, 1)));
                if (isVip) vipGuests.Remove(command);
                else regularGuests.Remove(command);
                command = Console.ReadLine();
            }
            Console.WriteLine(vipGuests.Count+regularGuests.Count);
            if(vipGuests.Count>0) Console.WriteLine(string.Join(Environment.NewLine,vipGuests));
            if(regularGuests.Count>0) Console.WriteLine(string.Join(Environment.NewLine, regularGuests));
        }
    }
}