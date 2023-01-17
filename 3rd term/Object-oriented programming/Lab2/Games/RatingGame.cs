namespace Lab2.Games
{
    public class RatingGame : _GameEntity
    {
        public RatingGame(_PlayerEntity opponentName, GameState battleGameState, int battleRating) : base(opponentName, battleGameState, battleRating)
        {
        }
    }
}