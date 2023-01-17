using System;
using Lab2.Games;

namespace Lab2.Players
{
    public class BasicPlayer : _PlayerEntity
    {
        public BasicPlayer(string userName, int initialRating) : base(userName, initialRating)
        {
            
        }

        // public override void WinGame(_GameEntity game)
        // {
        //     Rating += game.Rating;
        //     Games.Add(new GameHistory(game.OpponentName, GameState.Victory, game.Rating, game.GameId));
        // }
        
        //mu impl
        public override void WinGame(_PlayerEntity opponent, GameType gameType, int gameRating, Guid gameId)
        {
            Rating += gameRating;
            Games.Add(new GameHistory(opponent.UserName, GameState.Victory, gameRating, gameType, gameId));
        }

        public override void LoseGame(_PlayerEntity opponent, GameType gameType, int gameRating, Guid gameId)
        {
            Rating -= gameRating;
            Games.Add(new GameHistory(opponent.UserName, GameState.Defeat, gameRating, gameType, gameId));
        }
    }
}