using System;
using System.Collections.Generic;
using Lab2.Games;

namespace Lab2
{
    public abstract class _PlayerEntity
    {
        public string UserName { get; }
        public int Rating { get; set; }
        public List<GameHistory> Games { get; }
        public int GamesCount { get; set; } // redundant?

        public _PlayerEntity(string userName, int initialRating)
        {
            UserName = userName;
            Rating = initialRating;
            Games = new List<GameHistory>();
        }

        public abstract void WinGame(_PlayerEntity opponent, GameType gameType, int gameRating, Guid gameId);
        public abstract void LoseGame(_PlayerEntity opponent, GameType gameType, int gameRating, Guid gameId);

        public virtual void ShowStatistics()
        {
            Console.WriteLine("Current " + UserName + "`s rating: " + Rating + ", battles played: " + GamesCount);
        }
    }
}