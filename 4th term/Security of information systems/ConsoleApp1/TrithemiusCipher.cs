using System;

namespace Lab4
{
    class TritemiusCipher
    {
        private int[] k; // масив для зберігання ключа

        public TritemiusCipher(int[] k)
        {
            this.k = k;
        }

        public string Linear(string message, bool encrypt)
        {
            var encryptedMessage = "";
            for (int i = 0; i < message.Length; i++)
            {
                int newPosition = (k[0] * i + k[1]) % 1112064; // 1112064 - максимальне значення у таблиці Unicode

                int decodedValue;
                if (encrypt)
                {
                    decodedValue = ((int)message[i] + newPosition) % 1112064;
                }
                else
                {
                    decodedValue = ((int)message[i] - newPosition + 1112064) % 1112064;
                }
                char encryptedChar = (char)decodedValue;
                encryptedMessage += encryptedChar;
            }

            return encryptedMessage;
        }
        
        // Метод для шифрування повідомлення
        public string Encrypt(string message)
        {
            string encryptedMessage = "";
            for (int i = 0; i < message.Length; i++)
            {
                int newPosition = (k[0] * i + k[1]) % 1112064; // 1112064 - максимальне значення у таблиці Unicode
                int encryptedCharValue = ((int)message[i] + newPosition) % 1112064;
                char encryptedChar = (char)encryptedCharValue;
                encryptedMessage += encryptedChar;
            }

            return encryptedMessage;
        }

        // Метод для розшифрування повідомлення
        public string Decrypt(string encryptedMessage)
        {
            string decryptedMessage = "";
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                int newPosition = (k[0] * i + k[1]) % 1112064; // 1112064 - максимальне значення у таблиці Unicode
                int decryptedCharValue = ((int)encryptedMessage[i] - newPosition + 1112064) % 1112064;
                char decryptedChar = (char)decryptedCharValue;
                decryptedMessage += decryptedChar;
            }

            return decryptedMessage;
        }
    }
}