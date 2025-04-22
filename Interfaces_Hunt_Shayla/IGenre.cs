using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Hunt_Shayla
{
    class IGenre
    {
        /// <summary>
        /// Automatic properties for the Esrb, Genre, and Title, for the game or movie.
        /// </summary>
        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        // A defined method that will be implemented in the derived classes.
        public string Describe; 

    }
}
