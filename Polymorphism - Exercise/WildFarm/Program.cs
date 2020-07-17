using System;
using System.Collections.Generic;
using System.Linq;

namespace WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while(true)
            {
                string[] animalInfo = Console.ReadLine().Split();
                if (animalInfo[0] == "End") break;
                string[] foodInfo = Console.ReadLine().Split();
                string foodType = foodInfo[0];
                int foodQuantity = int.Parse(foodInfo[1]);

                switch (animalInfo[0])
                {
                    case "Owl":
                        string owlName = animalInfo[1];
                        double owlWeight = double.Parse(animalInfo[2]);
                        double owlWingSize = double.Parse(animalInfo[3]);
                        Owl owl = new Owl(owlName, owlWeight, owlWingSize);
                        animals.Add(owl);
                        Console.WriteLine(owl.MakeSound());
                        owl.FeedAnimal(foodType, foodQuantity);
                        break;
                    case "Hen":
                        string henName = animalInfo[1];
                        double henWeight = double.Parse(animalInfo[2]);
                        double henWingSize = double.Parse(animalInfo[3]);
                        Hen hen = new Hen(henName, henWeight, henWingSize);
                        animals.Add(hen);
                        Console.WriteLine(hen.MakeSound());
                        hen.FeedAnimal(foodType, foodQuantity);
                        break;
                    case "Mouse":
                        string mouseName = animalInfo[1];
                        double mouseWeight = double.Parse(animalInfo[2]);
                        string mouseLivingRegion = animalInfo[3];
                        Mouse mouse = new Mouse(mouseName, mouseWeight, mouseLivingRegion);
                        animals.Add(mouse);
                        Console.WriteLine(mouse.MakeSound());
                        mouse.FeedAnimal(foodType, foodQuantity);
                        break;
                    case "Dog":
                        string dogName = animalInfo[1];
                        double dogWeight = double.Parse(animalInfo[2]);
                        string dogLivingRegion = animalInfo[3];
                        Dog dog = new Dog(dogName, dogWeight, dogLivingRegion);
                        animals.Add(dog);
                        Console.WriteLine(dog.MakeSound());
                        dog.FeedAnimal(foodType, foodQuantity);
                        break;
                    case "Cat":
                        string catName = animalInfo[1];
                        double catWeight = double.Parse(animalInfo[2]);
                        string catLivingRegion = animalInfo[3];
                        string catBreed = animalInfo[4];
                        Cat cat = new Cat(catName, catWeight, catLivingRegion, catBreed);
                        animals.Add(cat);
                        Console.WriteLine(cat.MakeSound());
                        cat.FeedAnimal(foodType, foodQuantity);
                        break;
                    case "Tiger":
                        string tigerName = animalInfo[1];
                        double tigerWeight = double.Parse(animalInfo[2]);
                        string tigerLivingRegion = animalInfo[3];
                        string tigerBreed = animalInfo[4];
                        Tiger tiger = new Tiger(tigerName, tigerWeight, tigerLivingRegion, tigerBreed);
                        animals.Add(tiger);
                        Console.WriteLine(tiger.MakeSound());
                        tiger.FeedAnimal(foodType, foodQuantity);
                        break;
                }
            }
            foreach (var creature in animals)
            {
                Console.WriteLine(creature);
            }
        }
    }
}