namespace Lab2.Games
{
    public class BasicGame : _GameEntity
    {
        public BasicGame(_PlayerEntity opponentName, GameState battleGameState, int battleRating) : base(opponentName, battleGameState, battleRating)
        {
        }
    }
}