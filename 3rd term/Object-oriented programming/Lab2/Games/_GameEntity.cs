using System;

namespace Lab2
{
    public abstract class _GameEntity
    {
        public Guid GameId { get; set; }
        public int GameIndex { get; } // redundant?
        public string OpponentName { get; set; }
        public GameState GameState { get; set; }
        public int Rating { get; set; }

        public _GameEntity(_PlayerEntity opponentName, GameState battleGameState, int battleRating)
        {
            OpponentName = opponentName.UserName;
            GameState = battleGameState;
            Rating = battleRating;
            GameId = Guid.NewGuid();
            // if (!Status.Equals(GameState.Defeat))
            // {
            //     Index += 1;
            // }
            //
            // GameIndex = Index;
        }
        
        public virtual string ToString()
        {
            return $"{OpponentName} %5s {GameState} %5s {Rating} %5s {GameId}";
            return $"\t   {OpponentName}\t|\t{GameState}\t    |\t {Rating}\t |\t{GameIndex}\t";
        }
    }
}