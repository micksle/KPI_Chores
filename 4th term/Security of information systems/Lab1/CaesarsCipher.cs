using System;
using System.Text;

namespace Lab1
{
    public class CaesarsCipher
    {
        public void DoAction()
        {
            Console.WriteLine("Enter what would you like to do:\n1. Encrypt\n2. Decrypt");
            // var option = Console.ReadLine();
            var option = "1";

            if (!string.IsNullOrEmpty(option) && option.Equals("1"))
            {
                Console.Write("Enter the string you would like to encrypt: ");
                // var targetString = Console.ReadLine();
                Console.Write("Enter the encrypt key: ");
                // var encryptingKey = Console.ReadLine();
                var encryptingKey = "3";
                var key = (byte) 0;

                if (byte.TryParse(encryptingKey, out _) && !string.IsNullOrEmpty(encryptingKey))
                {
                    key = byte.Parse(encryptingKey);
                }

                var targetString = "new string is awesome!7";
                var result = Cipher(targetString, key, true);
                Console.WriteLine("FINAL RESULT: " + result);
                
                var finalResult = Cipher(result, key, false);
                Console.WriteLine("FINAL RESULT: " + finalResult);
            }
        }

        private static string Cipher(string executeString, byte key, bool encrypt)
        {
            var result = new StringBuilder();
            for (var i = 0; i < executeString.Length; i++)
            {
                var charValue = executeString[i];
                var unicodeByte = Encoding.Unicode.GetBytes(charValue.ToString());

                byte finalByte;
                if (encrypt)
                    finalByte = (byte)(unicodeByte[0] + key);
                else
                    finalByte = (byte)(unicodeByte[0] - key);

                var smt = new byte[] { finalByte, 0 };
                var finalChar = Encoding.Unicode.GetChars(smt);
                result.Append(finalChar[0]);
            }

            return result.ToString();
        }
    }
}