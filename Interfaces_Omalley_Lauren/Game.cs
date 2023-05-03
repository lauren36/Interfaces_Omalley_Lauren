using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Omalley_Lauren
{
    class Game : IGenre
    {
        /// <summary>
        /// Creates a public string for Esrb, Genre, and Title and gives them a get, set accessor.
        /// </summary>
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        // Creates a esrb, genre, and title Param then sets it equal to the Esrb, the Genre, and the Title.
        public Game(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        // The PlayGame creates a sentence that tells you the game title is starting, game on.
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is stating! Game ON!");
        }

        // The Describe creates a sentence that tells you the game title, genre, and the esrb.
        public string Describe()
        {
            return $"{Title} is a(n) {Genre} game, rated {Esrb}!";
        }
    }
}
