namespace Lab4
{
    public class smt
    {
        public static void Main()
        {
            int[] k = { 13, 10978 };  // задаємо ключ (A = 3, B = 7)
            TritemiusCipher cipher = new TritemiusCipher(k);

            string message = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine("Повідомлення: " + message);

            string encryptedMessage = cipher.Linear(message, true);
            Console.WriteLine("Зашифроване повідомлення: " + encryptedMessage);

            string decryptedMessage = cipher.Linear(message, false);
            Console.WriteLine("Розшифроване повідомлення: " + decryptedMessage);

            Console.WriteLine("\n\n" + "\n\n--");

            // var key = -120;
            // var targetString = "The five boxing wizards jump quickly";
            // foreach (var s in targetString)
            // {
            //     var initialInt = (int)s;
            //     // Console.Write("|   " + initialInt);
            //     var finalInt = initialInt + key;
            //     Console.WriteLine($"{initialInt}     |     {finalInt}");
            // }
            //
            // Console.WriteLine("\n\n------------------------------------------------");
            // CaesarCipher cs = new CaesarCipher();
            // cs.DoAction("З'їв аґрусу — та ягода цілюща б'є жах інфекцій шипучим „ь“ The five boxing wizards jump quickly",
            //     "-120", true);
            // Console.WriteLine(cs.FinalString);
            // cs.DoAction(cs.FinalString,
            //     "-120", false);
            // Console.WriteLine(cs.FinalString);
        }

    }
}