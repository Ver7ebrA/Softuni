using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Animals
{
    public class Engine
    {
        private const string END_OF_INPUT = "Beast!";

        private readonly List<Animal> animals;

        public Engine()
        {
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            string input = String.Empty;
            while ((input = Console.ReadLine()) != END_OF_INPUT)
            {
                string[] animalArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                Animal animal;

                try
                {
                    animal = GetAnimal(input, animalArgs);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    continue;
                }
                
                this.animals.Add(animal);
            }

            PrintAnimals();
        }

        private void PrintAnimals()
        {
            foreach (Animal animal in this.animals)
            {
                Console.WriteLine(animal);
            }
        }

        private Animal GetAnimal(string input, string[] animalArgs)
        {
            Animal animal;

            string animalType = input;
            string animalName = animalArgs[0];
            int animalAge = int.Parse(animalArgs[1]);
            string animalGender = GetGender(animalArgs);

            if (animalType == "Dog")
            {
                animal = new Dog(animalName, animalAge, animalGender);
            }
            else if (animalType == "Cat")
            {
                animal = new Cat(animalName, animalAge, animalGender);
            }
            else if (animalType == "Frog")
            {
                animal = new Frog(animalName, animalAge, animalGender);
            }
            else if (animalType == "Kitten")
            {
                animal = new Kitten(animalName, animalAge);
            }
            else if (animalType == "Tomcat")
            {
                animal = new Tomcat(animalName, animalAge);
            }
            else
            {
                throw new ArgumentException("Invalid input");
            }

            return animal;
        }

        private string GetGender(string[] animalArgs)
        {
            string animalGender = string.Empty;

            if (animalArgs.Length > 2)
            {
                animalGender = animalArgs[2];
            }

            return animalGender;
        }
    }
}
