using System.Collections.Generic;
using System.Linq;
using System;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.name = name;
            this.badges = 0;
            this.pokemons = new List<Pokemon>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
            }
        }

        public int Badges
        {
            get { return this.badges; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
        }

        public void AddBadge()
        {
            badges++;
        }

        public void ClearDeadPokemons()
        {
            if (this.pokemons.Count > 0 && this.pokemons.Where(p => p.Health <= 0).FirstOrDefault() != null)
            {
                this.pokemons = new List<Pokemon>(this.pokemons.Where(p => p.Health > 0)).ToList();
            }
        }
    }
}
