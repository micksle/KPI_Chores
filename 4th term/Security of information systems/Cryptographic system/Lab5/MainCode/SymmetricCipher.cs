using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Cryptographic_system.Lab5.MainCode
{
    public class SymmetricCipher
    {
        public string FinalString;
        DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

        public void DoAction(string targetString, string keyValue, InitializeVector vector, CipherMode mode, bool encrypt)
        {
            if (encrypt)
            {
                var finalString = Encrypt(targetString, keyValue, "vector");
                FinalString = Convert.ToBase64String(finalString);
            }
            else
            {
                var finalString = Decrypt(targetString, keyValue, "vector");
                FinalString = finalString;
            }
        }

        private static byte[] Encrypt(string text, string key, string iv)
        {
            var cryptic = new DESCryptoServiceProvider();
            cryptic.Key = Encoding.ASCII.GetBytes(key);
            cryptic.Mode = CipherMode.CBC;
            cryptic.IV = Encoding.ASCII.GetBytes(iv);

            var data = Encoding.UTF8.GetBytes(text);

            var memoryStream = new MemoryStream();
            var cryptoStream = new CryptoStream(memoryStream, cryptic.CreateEncryptor(), CryptoStreamMode.Write);
            {
                cryptoStream.Write(data, 0, data.Length);
                cryptoStream.FlushFinalBlock();
                return memoryStream.ToArray();
            }
        }

        private static string Decrypt(string targetString, string key, string iv)
        {
            var cryptic = new DESCryptoServiceProvider();
            var encryptedData = Encoding.UTF8.GetBytes(targetString);
            cryptic.Key = Encoding.ASCII.GetBytes(key);
            cryptic.Mode = CipherMode.CBC;
            cryptic.IV = Encoding.ASCII.GetBytes(iv);

            var memoryStream = new MemoryStream(encryptedData);
            var cryptoStream = new CryptoStream(memoryStream, cryptic.CreateDecryptor(), CryptoStreamMode.Read);
            var streamReader = new StreamReader(cryptoStream);
            return streamReader.ReadToEnd();
        }
    }
}