using System;
using Lab2.Games;

namespace Lab2.Players
{
    public class ProPlayer : _PlayerEntity
    {
        public ProPlayer(string userName, int initialRating) : base(userName, initialRating)
        {
            
        }

        public override void WinGame(_GameEntity game)
        {
            Rating += (int) (game.Rating * 1.2);
            Games.Add(new GameHistory(game.OpponentName, GameState.Victory, game.Rating, game.GameId));
        }

        public override void LoseGame(_GameEntity game)
        {
            Rating -= game.Rating;
            Games.Add(new GameHistory(game.OpponentName, GameState.Defeat, game.Rating, game.GameId));
        }
        
        public override void Print()
        {
            base.Print();
            Console.WriteLine("and from Pro");
            Console.WriteLine(Rating);
        }
    }
}