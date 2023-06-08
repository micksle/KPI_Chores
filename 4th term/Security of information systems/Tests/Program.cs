using System.Security.Cryptography;
using System.Text;

namespace Tests
{
    class Program
    {
        public static void Main()
        {
            var targetString =
                "Щастям б'єш жук їх глицю в фон й ґедзь пріч. The quick brown fox jumps over the lazy dog";
            string key = "ABCDABCD";
            string iv = "ABCDEFGH";

            byte[] encryptedData = Encrypt(targetString, key, iv);
            Console.WriteLine("Encrypted data: " + Convert.ToBase64String(encryptedData));

            string decryptedText = Decrypt(encryptedData, key, iv);
            Console.WriteLine("Decrypted text: " + decryptedText);
        }
        static byte[] Encrypt(string text, string key, string iv)
        {
            using (DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider())
            {
                cryptic.Key = Encoding.ASCII.GetBytes(key);
                cryptic.Mode = CipherMode.CBC;
                cryptic.IV = Encoding.ASCII.GetBytes(iv);

                byte[] data = Encoding.UTF8.GetBytes(text);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptic.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(data, 0, data.Length);
                        cryptoStream.FlushFinalBlock();
                        return memoryStream.ToArray();
                    }
                }
            }
        }

        static string Decrypt(byte[] encryptedData, string key, string iv)
        {
            using (DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider())
            {
                cryptic.Key = Encoding.ASCII.GetBytes(key);
                cryptic.Mode = CipherMode.CBC;
                cryptic.IV = Encoding.ASCII.GetBytes(iv);

                using (MemoryStream memoryStream = new MemoryStream(encryptedData))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptic.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}