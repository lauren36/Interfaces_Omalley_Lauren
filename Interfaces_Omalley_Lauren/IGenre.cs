using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Omalley_Lauren
{
    interface IGenre
    {
        /// <summary>
        /// Creates a public string for Esrb, Genre, and Title and gives them a get, set accessor.
        /// </summary>
        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        // Creates Describe method in the interface.
        public string Describe();
    }
}
