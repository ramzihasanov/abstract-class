using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song[] Songs = new Song[]
            {
                new Song("Adele", "21", 2011, "Rolling in the Deep")
            };
            foreach (var song in Songs)
            {
                song.Listen();
            }
        }
    }
}