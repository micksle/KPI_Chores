using System;
using Lab2.Games;

namespace Lab2.Players
{
    public class ProPlayer : _PlayerEntity
    {
        public ProPlayer(string userName, int initialRating) : base(userName, initialRating)
        {
            
        }
        //add to main class entity of gamehistory
        //add to gamehist list of games

        public override void WinGame(_PlayerEntity opponent, GameType gameType, int gameRating, Guid gameId)
        {
            Rating += (int) (gameRating * 1.2);
            Games.Add(new GameHistory(opponent.UserName, GameState.Victory, gameRating, gameType, gameId));
        }

        public override void LoseGame(_PlayerEntity opponent, GameType gameType, int gameRating, Guid gameId)
        {
            Rating -= gameRating;
            Games.Add(new GameHistory(opponent.UserName, GameState.Defeat, gameRating, gameType, gameId));
        }
    }
}