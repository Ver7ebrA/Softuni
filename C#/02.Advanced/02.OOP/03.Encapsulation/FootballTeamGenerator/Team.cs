using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public int GetRating
        {
            get
            {
                return this.Rating();
            }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player player = this.players.Where(p => p.Name == playerName).FirstOrDefault();

            if (player == null)
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }

            this.players.Remove(player);
        }

        private int Rating()
        {
            if (this.players.Count == 0)
            {
                return 0;
            }

            double result = 0;

            foreach (Player player in this.players)
            {
                result += player.OverallSkill;
            }

            return (int)Math.Round(result / this.players.Count);
        }
    }
}
