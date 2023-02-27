using System.Text;

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
                var initialInt = (int) s;
                int finalInt;

                if (encrypt)
                    finalInt = initialInt + key;
                else
                    finalInt = initialInt - key;

                var finalChar = (char) finalInt;
                finalString.Append(finalChar);
            }

            return finalString.ToString();
        }
    }
}