using System;
using Lab2.Games;

namespace Lab2.Players
{
    public class VipPlayer : _PlayerEntity
    {
        public VipPlayer(string userName, int initialRating) : base(userName, initialRating)
        {
            Rating += 10;
        }

        public override void WinGame(_GameEntity game)
        {
            Rating += (int) (game.Rating * 1.5);
            Games.Add(new GameHistory(game.OpponentName, GameState.Victory, game.Rating, game.GameId));
        }

        public override void LoseGame(_GameEntity game)
        {
            Rating -= (int) (game.Rating * 0.8);
            Games.Add(new GameHistory(game.OpponentName, GameState.Defeat, game.Rating, game.GameId));
        }
        
        public override void Print()
        {
            base.Print();
            Console.WriteLine("and from VIP");
            Console.WriteLine(Rating);
        }
    }
}