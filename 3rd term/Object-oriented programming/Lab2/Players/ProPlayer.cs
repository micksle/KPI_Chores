using System;
using Lab2.Games;

namespace Lab2.Players
{
    public class ProPlayer : _PlayerEntity
    {
        public ProPlayer(string userName, int initialRating) : base(userName, initialRating)
        {
        }

        public override void WinGame(_PlayerEntity opponent, GameType gameType, int gameRating)
        {
            GamesCount++;
            Rating += (int) (gameRating * 1.2);
            Games.Add(new GameHistory(opponent.UserName, GameState.Victory, gameRating, gameType));
        }

        public override void LoseGame(_PlayerEntity opponent, GameType gameType, int gameRating)
        {
            GamesCount++;
            Rating -= gameRating;
            Games.Add(new GameHistory(opponent.UserName, GameState.Defeat, gameRating, gameType));
        }
    }
}