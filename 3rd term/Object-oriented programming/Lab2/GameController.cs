using System;
using Lab2.Games;
using Lab2.Players;

namespace Lab2
{
    public class GameController
    {
        private int BattleAmount { get; set; }

        public void StartProgram(int battleAmount)
        {
            BattleAmount = battleAmount;
            Start();
        }

        private void Start()
        {
            var player1 = DefinePlayer();
            var player2 = DefinePlayer();
            var game = DefineGame(player1, player2);

            for (var i = 0; i < BattleAmount; i++)
            {
                game.PlayGame(player1, player2);
            }

            player1.ShowBattles();
            player2.ShowBattles();
            player1.ShowStatistics();
            player2.ShowStatistics();
        }

        private static _PlayerEntity DefinePlayer()
        {
            var exit = false;
            _PlayerEntity player = null;

            while (exit == false)
            {
                Console.WriteLine(" - \"basic\"\n - \"pro\"\n - \"VIP\"");
                Console.WriteLine(" Choose desired player:");
                var desired = Console.ReadLine();

                if (string.IsNullOrEmpty(desired)) continue;

                Console.WriteLine(" Enter player`s name");
                var name = Console.ReadLine();

                if (string.IsNullOrEmpty(name)) continue;

                switch (desired.ToLower())
                {
                    case "basic":
                        player = new BasicPlayer(name, 100);
                        exit = true;
                        break;
                    case "pro":
                        player = new ProPlayer(name, 100);
                        exit = true;
                        break;
                    case "vip":
                        player = new VipPlayer(name, 100);
                        exit = true;
                        break;
                }
            }

            Console.WriteLine("\nPlayer " + player.UserName + " created successfully!\n");
            return player;
        }

        private static _GameEntity DefineGame(_PlayerEntity player1, _PlayerEntity player2)
        {
            _GameEntity game = null;
            var exit = false;
            var random = new Random();

            while (exit == false)
            {
                Console.WriteLine(" - \"basic\"\n - \"training\"\n - \"death match\"");
                Console.WriteLine("\n Choose desired game:");
                var desired = Console.ReadLine();

                if (string.IsNullOrEmpty(desired)) continue;

                switch (desired.ToLower())
                {
                    case "basic":
                        game = new BasicGame(player1, player2, random.Next(10, 30));
                        exit = true;
                        break;
                    case "training":
                        game = new TrainingGame(player1, player2, random.Next(10, 30));
                        exit = true;
                        break;
                    case "death match":
                        game = new DeathMatchGame(player1, player2, random.Next(10, 30));
                        exit = true;
                        break;
                }
            }

            return game;
        }
    }
}