using System;

namespace Lab2
{
    public abstract class _GameEntity
    {
        protected Guid GameId { get; set; }
        private int Rating { get; }

        private _PlayerEntity Player1 { get; }
        private _PlayerEntity Player2 { get; }
        
        private Random Random { get; }

        protected _GameEntity(_PlayerEntity player1, _PlayerEntity player2, int battleRating)
        {
            Rating = battleRating;
            Player1 = player1;
            Player2 = player2;
            Random = new Random();
        }

        protected int GetRandom(int minValue, int maxValue)
        {
            return Random.Next(minValue, maxValue);
        }

        public abstract void PlayGame(_PlayerEntity player1, _PlayerEntity player2);
    }
}