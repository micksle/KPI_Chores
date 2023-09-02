using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Cryptographic_system.Lab5.MainCode
{
    public class SymmetricCipher
    {
        public string FinalString;

        public void DoAction(string targetString, string keyValue, string IVvalue, InitializeVector vector,
            CipherMode mode, bool encrypt)
        {
            if (encrypt)
            {
                switch (vector)
                {
                    case InitializeVector.DES: Encrypt(targetString, keyValue, IVvalue, new DESCryptoServiceProvider(), mode); break;
                    case InitializeVector.TripleDES: Encrypt(targetString, keyValue, IVvalue, new TripleDESCryptoServiceProvider(), mode); break;
                    case InitializeVector.AES: Encrypt(targetString, keyValue, IVvalue, new AesCryptoServiceProvider(),mode); break;
                }
            }
            else
            {
                switch (vector)
                {
                    case InitializeVector.DES: Decrypt(targetString, keyValue, IVvalue, new DESCryptoServiceProvider(),mode); break;
                    case InitializeVector.TripleDES: Decrypt(targetString, keyValue, IVvalue, new TripleDESCryptoServiceProvider(),mode); break;
                    case InitializeVector.AES: Decrypt(targetString, keyValue, IVvalue, new AesCryptoServiceProvider(),mode); break;
                }
            }
        }

        private void Encrypt(string targetString, string keyValue, string IV, SymmetricAlgorithm cs, CipherMode mode)
        {
            cs.Key = TrimValue(keyValue, cs);
            cs.IV = TrimValue(IV, cs);
            cs.Mode = mode;

            var stream = new FileStream(@"C:\Users\mickle\Desktop\БІС\Symmetric1.txt", FileMode.OpenOrCreate,
                FileAccess.Write);

            var crStream = new CryptoStream(stream,
                cs.CreateEncryptor(), CryptoStreamMode.Write);

            var data = Encoding.UTF8.GetBytes(targetString);
            crStream.Write(data, 0, data.Length);
            FinalString = Encoding.UTF8.GetString(data);

            crStream.Close();
            stream.Close();
        }

        private void Decrypt(string targetString, string keyValue, string IV, SymmetricAlgorithm cs, CipherMode mode)
        {
            cs.Key = TrimValue(keyValue, cs);
            cs.IV = TrimValue(IV, cs);
            cs.Mode = mode;

            var stream = new FileStream(@"C:\Users\mickle\Desktop\БІС\Symmetric1.txt", FileMode.OpenOrCreate,
                FileAccess.Read);

            var crStream = new CryptoStream(stream,
                cs.CreateDecryptor(), CryptoStreamMode.Read);

            var reader = new StreamReader(crStream);
            var data = reader.ReadToEnd();

            FinalString = data;
            crStream.Close();
            stream.Close();
        }

        private static byte[] TrimValue(string value, SymmetricAlgorithm cryptoProvider)
        {
            var val = Encoding.ASCII.GetBytes(value);
            var trimmedKey = new byte[cryptoProvider.KeySize / 8];
            Array.Copy(val, trimmedKey, Math.Min(val.Length, trimmedKey.Length));
            return trimmedKey;
        }
    }
}