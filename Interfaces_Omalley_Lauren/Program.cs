using System;

namespace Interfaces_Omalley_Lauren
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a new value for the Esrb, the Genre, and the Title for the Game Class.
            Game myGame = new Game("E", "FPS", "ZombCube");

            // Prints the Describe string and the PlayGame string to the Console with the new values implemented into the sentences.
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            // Creates a new value for the Esrb, the Genre, and the Title for the Movie Class.
            Movie myMovie = new Movie("PG", "Adventure/Comedy", "Sonic the Hedgehog 2");

            // Prints the Describe string and the PlayMovie string to the Console with the new values implemented into the sentences.
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
