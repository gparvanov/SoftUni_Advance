using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Elf elf = new Elf("Elfy",10);

            DarkWizard wiz = new DarkWizard("Wiz",12);

            BladeKnight blu = new BladeKnight("Blu", 15);

            Console.WriteLine(elf);
            Console.WriteLine(wiz);
            Console.WriteLine(blu);
        }
    }
}