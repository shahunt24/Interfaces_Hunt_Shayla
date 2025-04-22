namespace Interfaces_Hunt_Shayla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("E", "Endless runner", "Subway Surfers");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movie myMovie = new Movie("PG", "Adventure/Drama", "Barnyard");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
