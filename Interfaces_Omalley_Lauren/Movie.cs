using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Omalley_Lauren
{
    class Movie : IGenre
    {
        /// <summary>
        /// Creates a public string for Esrb, Genre, and Title and gives them a get, set accessor.
        /// </summary>
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        // Creates a esrb, genre, and title Param then sets it equal to the Esrb, the Genre, and the Title.
        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        // The PlayMovie creates a sentence that tells you the movie title is starting, sssshhhh.
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, SSSSHHHH!");
        }
        // The Describe creates a sentence that tells you the movie title, genre, and the esrb.
    public string Describe()
        {
            return $"{Title} is a(n) {Genre} movie, rated {Esrb}!";
        }
    }
}
