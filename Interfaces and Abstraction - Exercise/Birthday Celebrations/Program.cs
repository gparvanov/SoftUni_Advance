using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split();
            List<ICreature> ids = new List<ICreature>();

            while (inputData[0] != "End")
            {
                if (inputData.Length == 5)
                {
                    string humanName = inputData[1];
                    int age = int.Parse(inputData[2]);
                    string id = inputData[3];
                    string birthday = inputData[4];
                    Citizen citizen = new Citizen(humanName, age, id, birthday);
                    ids.Add(citizen);

                }
                else if (inputData.Length == 3 && inputData[0] == "Pet")
                {
                    string petName = inputData[1];
                    string birthday = inputData[2];
                    Pet pet = new Pet(petName, birthday);
                    ids.Add(pet);
                }
                else if (inputData.Length == 3 && inputData[0] == "Robot")
                {

                }
                inputData = Console.ReadLine().Split();
            }

            string year = Console.ReadLine();            
            foreach (var record in ids)
            {
                if (record is Citizen citizen)
                {
                    if (citizen.Birthday.EndsWith(year)) Console.WriteLine(citizen.Birthday);         
                    
                }
                else if (record is Pet pet)
                {
                    if (pet.Birthday.EndsWith(year)) Console.WriteLine(pet.Birthday);                       
                    
                }
            }            
        }
    }
}