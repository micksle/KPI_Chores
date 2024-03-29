﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class GameAccount
    {
        private List<Game> _games = new List<Game>();
        public string UserName { get; }
        private int CurrentRating { get; set; }
        private int GamesCount { get; set; }

        public GameAccount(string userName, int initialRating)
        {
            UserName = userName;
            CurrentRating = initialRating;
        }

        public static void PlayGame(GameAccount player1, GameAccount player2, int gamesQuantity)
        {
            var random = new Random();
            for (int i = 0; i < gamesQuantity; i++)
            {
                int winNumber = random.Next(20);
                int ratingValue = random.Next(-1, 50);

                Console.WriteLine("\trandom winNumber: " + winNumber + ", random battleRating value: " + ratingValue);
                if (winNumber > 10)
                {
                    player1.WinGame(player2, ratingValue);
                    player2.LoseGame(player1, ratingValue);
                }
                else
                {
                    player2.WinGame(player1, ratingValue);
                    player1.LoseGame(player2, ratingValue);
                }
            }

            Console.WriteLine("_________________________________________________________\n");
            player1.GetStats();
            player2.GetStats();
        }

        private void WinGame(GameAccount opponentName, int rating)
        {
            if (rating < 0)
            {
                throw new InvalidOperationException("Error! The battle rating can not be negative");
            }

            GamesCount++;
            // CurrentRating += rating;
            _games.Add(new Game(opponentName, GameState.Victory, rating));
        }

        private void LoseGame(GameAccount opponentName, int rating)
        {
            if (rating < 0)
            {
                throw new InvalidOperationException("Error! The battle rating can not be negative");
            }

            GamesCount++;
            // CurrentRating -= rating;
            _games.Add(new Game(opponentName, GameState.Defeat, -rating));
        }

        private void GetStats()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("\n\t\t\t\t  BATTLE LOG:");
            str.AppendLine("\topponent name   |   battle status   |   rating   |    battle index");
            foreach (var g in _games)
            {
                str.AppendLine(g.ToString());
                if (CurrentRating + g.Rating < 1)
                {
                    CurrentRating = 1;
                }
                else
                {
                    CurrentRating += g.Rating;
                }
            }

            Console.WriteLine(str);
            Console.WriteLine("Current " + UserName + "`s rating: " + CurrentRating + ", battles played: " +
                              GamesCount);
        }
    }
}