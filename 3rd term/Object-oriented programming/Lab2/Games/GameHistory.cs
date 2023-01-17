using System;

namespace Lab2.Games
{
    public class GameHistory
    {
        private string OpponentName { get; }
        private GameState Status { get; }
        private int Rating { get; }
        private GameType GameType { get; }
        private Guid GameIndex { get; }

        public GameHistory(string opponentName, GameState status, int rating, GameType gameType, Guid gameIndex)
        {
            OpponentName = opponentName;
            Status = status;
            Rating = rating;
            GameType = gameType;
            GameIndex = gameIndex;
        }

        public override string ToString()
        {
            return $"{OpponentName, 15}  |{Status, 12}   | {Rating, 10} | {GameType, 10} |  {GameIndex, -40}";
        }
    }
}