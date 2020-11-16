using System;
using System.Collections.Generic;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal frog = new Frog("frog1", "Male", 20);
            Animal frog2 = new Frog("frog2", "Male", 6);

            Animal cat = new Cat("cat1", "Male", 7);
            Animal cat2 = new Cat("cat2", "Male", 14);


            List<Animal> listAnimal = new List<Animal> { frog, frog2, cat, cat2 };
            
            GetAverageAge(listAnimal);
        }
        public static void GetAverageAge(List<Animal> listAnimal)
        {
          
            int avgAgeFrog=0, avgAgeCat=0,avgAgeDog = 0, avgAgeAnimals = 0;
            int CountFrog = 0, CountCat = 0, CountDog = 0;
            for (int i = 0; i < listAnimal.Count; i++)
            {
                avgAgeAnimals += listAnimal[i].Age;
                
                if (listAnimal[i].GetType().ToString() == "AnimalHierarchy.Frog")
                {
                    avgAgeFrog += listAnimal[i].Age;
                    CountFrog++;
                }
                else if (listAnimal[i].GetType().ToString() == "AnimalHierarchy.Cat")
                {
                    avgAgeCat += listAnimal[i].Age;
                    CountCat++;
                }
                else
                {
                    avgAgeDog += listAnimal[i].Age;
                    CountDog++;
                }
            }
            if (CountCat != 0)
            {
                avgAgeCat /= CountCat;
            }
            if (CountDog != 0)
            {
                avgAgeDog /= CountDog;
            }
            if (CountFrog != 0)
            {
                avgAgeFrog /= CountFrog;
            }

            avgAgeAnimals /= listAnimal.Count;
            Console.WriteLine($"Average age for all animals: {avgAgeAnimals}, Average age for frogs: {avgAgeFrog}, Average age for cats: {avgAgeCat}, Average age for dogs: {avgAgeDog}  ");

        }

    }
}
