using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Queue<Trainer> trainers = new Queue<Trainer>();

            string input = Console.ReadLine().Trim();

            while (input != "Tournament")
            {
                string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = inputArr[0];
                string pokemonName = inputArr[1];
                string pokemonElement = inputArr[2];
                int pokemonHealth = int.Parse(inputArr[3]);
                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer currentTrainer = trainers.Where(t => t.Name == trainerName).FirstOrDefault();

                if (currentTrainer == null)
                {
                    currentTrainer = new Trainer(trainerName);
                    trainers.Enqueue(currentTrainer);
                    currentTrainer.Pokemons.Add(currentPokemon);
                }
                else
                {
                    currentTrainer.Pokemons.Add(currentPokemon);
                }

                input = Console.ReadLine().Trim();
            }

            string command = Console.ReadLine().Trim();

            while (command != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Where(p => p.Element == command).FirstOrDefault() != null)
                    {
                        trainer.AddBadge();
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.DamagePokemons();
                        }

                        trainer.ClearDeadPokemons();
                    }
                }

                command = Console.ReadLine().Trim();
            }

            Console.WriteLine(String.Join(Environment.NewLine, trainers
                .OrderByDescending(t => t.Badges)
                .Select(t => $"{t.Name} {t.Badges} {t.Pokemons.Count}")));
        }
    }
}
