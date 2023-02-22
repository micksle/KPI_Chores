using System;

namespace Lab2.Games
{
    public class TrainingGame : _GameEntity
    {
        public TrainingGame(_PlayerEntity player1, _PlayerEntity player2, int battleRating) : base(player1, player2, battleRating)
        {
        }
        
        public override void PlayGame(_PlayerEntity player1, _PlayerEntity player2)
        {
            var winNumber = GetRandom(0, 5);
            Console.WriteLine("\trandom winNumber: " + winNumber);
           
            
            if (winNumber > 2)
            {
                GameId = Guid.NewGuid();
                player1.WinGame(player2, GameType.Training, 0);
                player2.LoseGame(player1, GameType.Training, 0);
            }
            else
            {
                GameId = Guid.NewGuid();
                player2.WinGame(player1, GameType.Training, 0);
                player1.LoseGame(player2, GameType.Training, 0);
            }
        }
    }
}