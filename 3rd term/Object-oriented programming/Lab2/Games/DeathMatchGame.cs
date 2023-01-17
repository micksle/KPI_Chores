using System;

namespace Lab2.Games
{
    public class DeathMatchGame : _GameEntity
    {
        public DeathMatchGame(_PlayerEntity player1, _PlayerEntity player2, int battleRating) : base(player1, player2, battleRating)
        {
        }

        public override void PlayGame(_PlayerEntity player1, _PlayerEntity player2)
        {
            var winNumber = GetRandom(0, 5);
            var ratingValue = GetRandom(-1, 50);
            Console.WriteLine("\trandom winNumber: " + winNumber + ", random battleRating value: " + ratingValue);
           
            
            if (winNumber > 2)
            {
                GameId = Guid.NewGuid();
                player1.WinGame(player2, GameType.DeathMatch, ratingValue, GameId);
                player2.LoseGame(player1, GameType.DeathMatch, 0, GameId);
            }
            else
            {
                GameId = Guid.NewGuid();
                player2.WinGame(player1, GameType.DeathMatch, ratingValue, GameId);
                player1.LoseGame(player2, GameType.DeathMatch, 0, GameId);
            }
        }
    }
}