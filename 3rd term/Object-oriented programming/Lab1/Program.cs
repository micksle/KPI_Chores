namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var player1 = new GameAccount("player1", 50);
            var player2 = new GameAccount("player2", 100);
            GameAccount.PlayGame(player1, player2, 6);
        }
    }
}