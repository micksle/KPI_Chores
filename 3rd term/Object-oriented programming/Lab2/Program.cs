using System;

namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("___________________________________________\n");

            var game = new GameController();
            game.StartProgram(3);

        }
    }
}