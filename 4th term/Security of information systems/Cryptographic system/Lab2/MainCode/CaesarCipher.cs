using System;
using System.Text;
using System.Windows.Forms;

namespace Cryptographic_system.Lab2.MainCode
{
    // З'їв аґрусу — та ягода цілюща б'є жах інфекцій шипучим „ь“.
    // The five boxing wizards jump quickly
    
    internal class CaesarCipher
    {
        public string FinalString;

        public void DoAction(string targetString, string encryptingKey, bool encrypt)
        {
            var key = int.Parse(encryptingKey);
            FinalString = Cipher(targetString, key, encrypt);
        }

        public string Cipher(string targetString, int key, bool encrypt)
        {
            var finalString = new StringBuilder();

            foreach (var c in targetString)
            {
                var initialInt = (int)c;
                int finalInt;

                if (encrypt)
                    finalInt = (initialInt + key) % 65536;
                else
                    finalInt = (initialInt - key % 65536 + 65536) % 65536;

                var finalChar = (char)finalInt;
                finalString.Append(finalChar);
            }

            return finalString.ToString();
        }

        public void BruteForce(string encryptedString, string toFind)
        {
            var find = false;
            var i = 0;
            var decryptedValue = "";
            int encryptValue;

            int firstEncrypted = encryptedString[0];
            int firstToFind = toFind[0];
            var positive = firstToFind - firstEncrypted < 0;

            while (find == false)
            {
                try
                {
                    if (positive)
                        encryptValue = i;
                    else
                        encryptValue = -i;

                    decryptedValue = Cipher(encryptedString, encryptValue, false);
                    if (decryptedValue == toFind)
                        find = true;

                    if (Math.Abs(i) >= 17000)
                    {
                        throw new OutOfMemoryException();
                    }

                    i++;
                }
                catch (OutOfMemoryException e)
                {
                    MessageBox.Show(
                        @"			ERROR

Memory limit exceeded, seems like the choosen file was unpropriate, unable to use ""brute decription"" method");
                    Console.WriteLine(e);
                    return;
                }
            }

            FinalString = decryptedValue;

            if (positive)
                MessageBox.Show("Text decrypted succesfully, with the key value = " + (i - 1));
            else
                MessageBox.Show("Text decrypted succesfully, with the key value = " + (-i + 1));
        }
    }
}