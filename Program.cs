using System;

namespace DIO.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie serie = new Serie(
                1, Genre.Animated, "Star Wars", "Long time ago", 1989
            );
            Console.WriteLine(serie);
        }
    }
}
