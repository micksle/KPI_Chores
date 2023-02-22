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
        /*
         * генерація ID гри для історії обовязкова, для збереження останнього ID використовуйте статичні властивості
         * рейтинг повинен мати метод get, який буде за списком ігор обраховувати своє поточне значення
         * перевірка рейтингу у сетерах
         *
         * Міша х Саша - айді 1
Саша х Маша - айді 2
Коля х Маша - айді 3

тоді у Міши в списку історії 
- гра проти Саші з айді 1

У Саші в списку історії
- гра проти Міші з айді 1
- гра проти Маші з айді 2

У Маші в списку історії
- гра проти Саші з айді 2
- гра проти Колі з айді 3

неправильне використання поліморфізму та неправильне розподіленя відповідальності між класами
наприклад, обрахунок подвійного рейтингу для VIP аккаунту не в самому класі VIPAccount, а десь поза його межами
         */

        public GameHistory(string opponentName, GameState status, int rating, GameType gameType)
        {
            OpponentName = opponentName;
            Status = status;
            Rating = rating;
            GameType = gameType;
            GameIndex = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"{OpponentName, 15}  |{Status, 12}   | {Rating, 10} | {GameType, 10} |  {GameIndex, -40}";
        }
    }
}