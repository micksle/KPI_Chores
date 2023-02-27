using System.Text;
using System.Windows.Forms;

namespace Security_of_information_systems.MainCode
{
    // З'їв аґрусу — та ягода цілюща б'є жах інфекцій шипучим „ь“.
    // The five boxing wizards jump quickly
    internal class CaesarCipher : ICryptography
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

            foreach (var s in targetString)
            {
                var initialInt = (int)s;
                int finalInt;

                if (encrypt)
                    finalInt = initialInt + key;
                else
                    finalInt = initialInt - key;

                var finalChar = (char)finalInt;
                finalString.Append(finalChar);
            }

            return finalString.ToString();
        }

        public void BruteForce(string encryptedString, string toFind)
        {
            var find = false;
            var i = 0;
            string decryptedValue;
            int encryptValue;

            var firstEncrypted = (int)encryptedString[0];
            var firstToFind = (int)toFind[0];
            bool positive;

            if (firstToFind - firstEncrypted < 0)
                positive = true;
            else
                positive = false;

            while (find == false)
            {
                if (!positive)
                    encryptValue = i;
                else
                    encryptValue = -i;

                decryptedValue = Cipher(encryptedString, encryptValue, false);
                if (decryptedValue == toFind)
                    find = true;

                i++;
            }

            if (!positive)
                MessageBox.Show("Text decrypted succesfully, with the key value = " + (i - 1));
            else
                MessageBox.Show("Text decrypted succesfully, with the key value = " + (-i + 1));
        }
    }
}