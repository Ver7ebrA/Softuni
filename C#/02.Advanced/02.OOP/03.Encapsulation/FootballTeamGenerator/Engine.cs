using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Engine
    {
        private List<Team> teams;

        public Engine()
        {
            this.teams = new List<Team>();
        }

        public void Run()
        {
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] commandArg = command.Split(';', StringSplitOptions.None);

                    if (commandArg[0] == "Team")
                    {
                        Team team = new Team(commandArg[1]);
                        teams.Add(team);
                    }
                    else if (commandArg[0] == "Add")
                    {
                        string teamName = commandArg[1];
                        string playerName = commandArg[2];
                        int playerEndurance = int.Parse(commandArg[3]);
                        int playerSprint = int.Parse(commandArg[4]);
                        int playerDribble = int.Parse(commandArg[5]);
                        int playerPassing = int.Parse(commandArg[6]);
                        int playerShooting = int.Parse(commandArg[7]);

                        Stats stats = new Stats(playerEndurance, playerSprint, playerDribble, playerPassing, playerShooting);
                        Player player = new Player(playerName, stats);

                        AddPlayerToTeam(teamName, player);
                    }
                    else if (commandArg[0] == "Remove")
                    {
                        string teamName = commandArg[1];
                        string playerName = commandArg[2];

                        RemovePlayerFromTeam(teamName, playerName);
                    }
                    else if (commandArg[0] == "Rating")
                    {
                        string teamName = commandArg[1];

                        Console.WriteLine(TeamRating(teamName));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }



        private Team ValidateTeam(string teamName)
        {
            Team team = teams.Where(t => t.Name == teamName).FirstOrDefault();

            if (team == null)
            {
                throw new InvalidOperationException($"Team {teamName} does not exist.");
            }

            return team;
        }

        public void AddPlayerToTeam(string teamName, Player player)
        {
            Team team = ValidateTeam(teamName);

            team.AddPlayer(player);
        }

        public void RemovePlayerFromTeam(string teamName, string playerName)
        {
            Team team = ValidateTeam(teamName);

            team.RemovePlayer(playerName);
        }

        public string TeamRating(string teamName)
        {
            Team team = ValidateTeam(teamName);

            return $"{team.Name} - {team.GetRating}";
        }
    }
}
