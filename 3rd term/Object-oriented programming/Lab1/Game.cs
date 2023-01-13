using System;

namespace Lab1
{
    public class Game
    {
        private static Random random = new Random();
        private static int Index { get; set; } = random.Next(1102, 1437);
        private int GameIndex { get; }
        private string OpponentName { get; }
        private GameState Status { get; }
        public int Rating { get; }

        public Game(GameAccount opponentName, GameState battleStatus, int battleRating)
        {
            OpponentName = opponentName.UserName;
            Status = battleStatus;
            Rating = battleRating;
            if (!Status.Equals(GameState.Defeat))
            {
                Index += 1;
            }

            GameIndex = Index;
        }

        public new string ToString()
        {
            return $"\t   {OpponentName}\t|\t{Status}\t    |\t {Rating}\t |\t{GameIndex}\t";
        }
    }
}