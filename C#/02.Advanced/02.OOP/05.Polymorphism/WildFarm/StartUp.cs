using System;
using WildFarm.Factories;
using WildFarm.Animals;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Mammals;
using WildFarm.Animals.Mammals.Felines;
using WildFarm.Foods;
using System.Collections.Generic;


namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalArgs = input.Split();
                string[] foodArgs = Console.ReadLine().Split();

                try
                {
                    Animal animal = AnimalFactory.Create(animalArgs);
                    Console.WriteLine(animal.ProduceSound());
                    animals.Add(animal);
                    Food food = FoodFactory.Create(foodArgs);
                    animal.EatFood(food);                  
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
