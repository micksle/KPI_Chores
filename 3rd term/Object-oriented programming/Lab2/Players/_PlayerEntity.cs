﻿using System;
using System.Collections.Generic;
using Lab2.Games;

namespace Lab2
{
    public abstract class _PlayerEntity
    {
        public string UserName { get; }
        protected int Rating { get; set; }
        public List<GameHistory> Games { get; }
        protected int GamesCount { get; set; }

        protected _PlayerEntity(string userName, int initialRating)
        {
            UserName = userName;
            Rating = initialRating;
            Games = new List<GameHistory>();
        }

        public abstract void WinGame(_PlayerEntity opponent, GameType gameType, int gameRating);
        public abstract void LoseGame(_PlayerEntity opponent, GameType gameType, int gameRating);

        public void ShowStatistics()
        {
            Console.WriteLine("Current " + UserName + "`s rating: " + Rating + ", battles played: " + GamesCount);
        }

        public void ShowBattles()
        {
            var title = $"{"Opponent Name", 15}  |{"Battle Status", 14} | {"Rating", 10} | {"Game Type", 10} |  {"GameIndex", -40}";
            Console.WriteLine("\n" + title);
            Games.ForEach(Console.WriteLine);
        }
    }
}