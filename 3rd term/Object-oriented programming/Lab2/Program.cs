using System;
using System.Text;
using Lab2.Games;
using Lab2.Players;

namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var player1 = new BasicPlayer("basic", 20);
            var player2 = new ProPlayer("pro", 40);
            PlayGame(player1, player2, 4);

            GetStats(player1);
            GetStats(player2);

        }
        
        public static void PlayGame(_PlayerEntity player1, _PlayerEntity player2, int gamesQuantity)
        {
            var random = new Random();
            for (int i = 0; i < gamesQuantity; i++)
            {
                int winNumber = random.Next(20);
                int ratingValue = random.Next(-1, 50);

                Console.WriteLine("\trandom winNumber: " + winNumber + ", random battleRating value: " + ratingValue);
                if (winNumber > 10)
                {
                    player1.WinGame(new BasicGame(new BasicPlayer("basic", 20), GameState.Victory, 10));
                    player2.LoseGame(new BasicGame(new ProPlayer("pro", 40), GameState.Victory, 10));
                }
                else
                {
                    player2.WinGame(new BasicGame(new ProPlayer("pro", 40), GameState.Victory, 30));
                    player1.LoseGame(new BasicGame(new BasicPlayer("basic", 20), GameState.Victory, 30));
                }
            }

            Console.WriteLine("_________________________________________________________\n");
            var sb = new StringBuilder();
            sb.Append($"{"Opponent Name", 15}  |{"Battle Status", 14} | {"Rating", 10} |  {"GameIndex", -40}");
            Console.WriteLine(sb);
            player1.Games.ForEach(Console.WriteLine);
            Console.WriteLine("\n----------- PLAYER 2 -----------\n");
            player2.Games.ForEach(Console.WriteLine);
        }

        private static void GetStats(_PlayerEntity player)
        {
            // StringBuilder str = new StringBuilder();
            // str.AppendLine("\n\t\t\t\t  BATTLE LOG:");
            // str.AppendLine("\topponent name   |   battle status   |   rating   |    battle index");
            // foreach (var g in _games)
            // {
            //     str.AppendLine(g.ToString());
            //     if (CurrentRating + g.Rating < 1)
            //     {
            //         CurrentRating = 1;
            //     }
            //     else
            //     {
            //         CurrentRating += g.Rating;
            //     }
            // }
        
            // Console.WriteLine(str);
            Console.WriteLine("Current " + player.UserName + "`s rating: " + player.Rating + ", battles played: " +
                              player.GamesCount);
        }
    }
}