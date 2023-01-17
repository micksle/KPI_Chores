namespace Lab2.Games
{
    public class TrainingGame : _GameEntity
    {
        public TrainingGame(_PlayerEntity opponentName, GameState battleGameState, int battleRating) : base(opponentName, battleGameState, battleRating)
        {
        }
    }
}