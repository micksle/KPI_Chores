using System;
using System.Text;

namespace Lab1
{
    public class CaesarsCipher
    {
        public void DoAction()
        {
            Console.WriteLine("Enter what would you like to do:\n 1. Encrypt\n 2. Decrypt");
            // var option = Console.ReadLine();
            var option = "1";

            if (!string.IsNullOrEmpty(option) && option.Equals("1"))
            {
                Console.Write("Enter the string you would like to encrypt: ");
                // var targetString = Console.ReadLine();
                Console.Write("\nEnter the encrypt key: ");
                // var encryptingKey = Console.ReadLine();
                var encryptingKey = "1";
                var key = (byte) 0;

                if (byte.TryParse(encryptingKey, out _) && !string.IsNullOrEmpty(encryptingKey))
                {
                    key = byte.Parse(encryptingKey);
                }

                var targetString = "Факт ґринджол: бій псюг вщух, з'їм шче яєць. yoskiñ is awtsome!7";
                Console.WriteLine("\nINITIAL STRING: " + targetString);
                var result = Cipher(targetString, key, true);
                Console.WriteLine("\nFINAL RESULT: " + result);
            }
        }

        private static string Cipher(string targetString, byte key, bool encrypt)
        {
            var chars = targetString.ToCharArray();
            var resultString = new StringBuilder();

            for (var i = 0; i < chars.Length; i++)
            {
                var bytes = GetUtf8Bytes(chars[i]);

                foreach (var b in bytes)
                {
                    Console.WriteLine(b);
                }

                for (var j = 0; j < bytes.Length; j++)
                {
                    if (i % 2 != 0)
                    {
                        bytes[j] += key;
                        Console.WriteLine(bytes[j] + "  |");
                    }
                }

                var finalChar = GetStringFromUtf8(bytes);
                Console.WriteLine("--------------");
                resultString.Append(finalChar);
            }

            return resultString.ToString();
        }

        private static byte[] GetUtf8Bytes(char c)
        {
            var encoding = new UTF8Encoding(false);
            return encoding.GetBytes(new[] { c });
        }

        private static string GetStringFromUtf8(byte[] bytes)
        {
            var encoding = new UTF8Encoding(); // It should figure out if there's a BOM or not.
            return encoding.GetString(bytes);
        }
    }
}