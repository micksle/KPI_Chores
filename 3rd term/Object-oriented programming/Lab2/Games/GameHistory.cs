using System;

namespace Lab2.Games
{
    public class GameHistory
    {
        public string OpponentName { get; set; }
        public GameState Status { get; set; }
        public int Rating { get; set; }
        public GameType GameType { get; }
        public Guid GameIndex { get; set; }

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