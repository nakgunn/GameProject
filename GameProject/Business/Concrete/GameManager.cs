using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game was added: " + game.Name);
        }
        public void Delete(Game game)
        {
            Console.WriteLine("Game was deleted: " + game.Name);
        }
        public void List(List<Game> games)
        {
            Console.WriteLine("Game was listed.");
            foreach (var game in games)
            {
                Console.WriteLine(game.Name);
            }
        }
        public void Update(Game game)
        {
            Console.WriteLine("Game was updated: " + game.Name);
        }
    }
}
