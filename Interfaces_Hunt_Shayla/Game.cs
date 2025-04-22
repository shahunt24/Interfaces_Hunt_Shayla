using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Hunt_Shayla
{
    internal class Game : IGenre
    {
        /// <summary>
        /// Automatic properties for the ESRB, Genre, and Title for the game.
        /// </summary>
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        /// <summary>
        /// Constructor for the Game class that initializes the Esrb, Genre, and Title properties.
        /// </summary>
        /// <param name="esrbParam"></param>
        /// <param name="genreParam"></param>
        /// <param name="titleParam"></param>
        public Game(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        /// <summary>
        /// Method to simulate playing the game.
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting!");
        }

        /// <summary>
        /// Method to describe the game, including its title, genre, and ESRB rating.
        /// </summary>
        /// <returns></returns>
        public string Describe()
        {
            return $"{Title} is a {Genre} game, rated {Esrb}!";
        }


    }
}
