using System;
using Lab2.Games;

namespace Lab2.Players
{
    public class VipPlayer : _PlayerEntity
    {
        public VipPlayer(string userName, int initialRating) : base(userName, initialRating)
        {
        }

        public override void WinGame(_PlayerEntity opponent, GameType gameType, int gameRating)
        {
            GamesCount++;
            Rating += (int) (gameRating * 1.5);
            Games.Add(new GameHistory(opponent.UserName, GameState.Victory, gameRating, gameType));
        }

        public override void LoseGame(_PlayerEntity opponent, GameType gameType, int gameRating)
        {
            GamesCount++;
            Rating -= (int) (gameRating * 0.8);
            Games.Add(new GameHistory(opponent.UserName, GameState.Defeat, gameRating, gameType));
        }
    }
}