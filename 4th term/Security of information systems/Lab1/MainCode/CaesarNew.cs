using System.Text;

namespace Security_of_information_systems.MainCode
{
    // З'їв аґрусу — та ягода цілюща б'є жах інфекцій шипучим „ь“.
    // The five boxing wizards jump quickly
    internal class CaesarNew
    {
        public string FinalString;

        public void DoAction(string targetString, string encryptingKey, bool encrypt)
        {
            var key = int.Parse(encryptingKey);
            FinalString = Cipher(targetString, key, encrypt);
        }

        public static string Cipher(string targetString, int key, bool encrypt)
        {
            var finalString = new StringBuilder();

            for (var i = 0; i < targetString.Length; i++)
            {
                var initialInt = (int) targetString[i];
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