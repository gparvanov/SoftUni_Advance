using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, List<Animal>> animals = new Dictionary<string, List<Animal>>();

            string animal = Console.ReadLine().Trim();

            while (animal != "Beast!")
            {
                string type = animal;
                if (type == "") Console.WriteLine("Invalid input!");
                else
                {
                    string[] animalDetails = Console.ReadLine().Trim().Split();

                    string animalName = animalDetails[0];
                    int animalAge = 0;
                    bool isDigit = int.TryParse(animalDetails[1], out animalAge);
                    if (isDigit)
                    {
                        animalAge = int.Parse(animalDetails[1]);
                        string animalGender = "";
                        if (type != "Kitten" && type != "Tomcat")
                        {
                            if (animalDetails.Length != 3)
                            {
                                Console.WriteLine("Invalid input!");
                            }
                            else animalGender = animalDetails[2].Trim();
                        }
                        else animalGender = "No matter";
                        if (animalGender != "")
                        {
                            if (!animals.ContainsKey(type))
                            {
                                animals[type] = new List<Animal>();
                            }
                            if (animalAge < 0 ) Console.WriteLine("Invalid input!");
                            else
                            {
                                switch (type)
                                {
                                    case "Cat":
                                        Cat tempCat = new Cat(animalName, animalAge, animalGender);
                                        animals[type].Add(tempCat);
                                        break;
                                    case "Dog":
                                        Dog tempDog = new Dog(animalName, animalAge, animalGender);
                                        animals[type].Add(tempDog);
                                        break;
                                    case "Frog":
                                        Frog tempFrog = new Frog(animalName, animalAge, animalGender);
                                        animals[type].Add(tempFrog);
                                        break;
                                    case "Kitten":
                                        Kitten tempKitten = new Kitten(animalName, animalAge);
                                        animals[type].Add(tempKitten);
                                        break;
                                    case "Tomcat":
                                        Tomcat tempTomcat = new Tomcat(animalName, animalAge);
                                        animals[type].Add(tempTomcat);
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                animal = Console.ReadLine();
            }
            foreach (var type in animals)
            {
                foreach (var innerAnimal in type.Value)
                {
                    Console.WriteLine($"{type.Key}");
                    Console.WriteLine($"{innerAnimal.Name} {innerAnimal.Age} {innerAnimal.Gender}");
                    Console.WriteLine($"{innerAnimal.ProduceSound()}");
                }
            }
        }
    }
}