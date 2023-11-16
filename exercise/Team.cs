using System;
using System.Collections.Generic;
namespace exercise
{
    public class Team
    {
        public string Name { get; private set; }
        public List<Game> Games { get; private set; }

        public Team(string name)
        {
            Name = name;
            Games = new List<Game>();
        }

        public void AddGame(Game game)
        {
            Games.Add(game);
        }

        public void PlayGames()
        {
            Console.WriteLine($"Команда {Name} играет в следующие игры:");
            foreach (var game in Games)
            {
                game.Play();
            }
        }
    }
}
