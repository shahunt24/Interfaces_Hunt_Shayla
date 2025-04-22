using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Hunt_Shayla
{
    internal class Movie : IGenre
    {
        /// <summary>
        /// Automatic properties for the ESRB, Genre, and Title for the movie.
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
        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        /// <summary>
        /// Method to simulate playing the movie.
        /// </summary>
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, Ssssshhhhh");
        }

        /// <summary>
        /// Method to describe the movie, including its title, genre, and ESRB rating.
        /// </summary>
        /// <returns></returns>
        public string Describe()
        {
            return $"{Title} is a {Genre} movie, and rated {Esrb}!";
        }
    }
}
