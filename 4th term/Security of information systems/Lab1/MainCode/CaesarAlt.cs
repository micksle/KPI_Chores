using System.Text;

namespace Security_of_information_systems.MainCode
{
    // З'їв аґрусу — та ягода цілюща б'є жах інфекцій шипучим „ь“.
    // The five boxing wizards jump quickly
    internal class CaesarAlt
    {
        public string FinalString;

        public void DoAction(string targetString, string encryptingKey, bool encrypt)
        {
            var key = byte.Parse(encryptingKey);
            FinalString = Cipher(targetString, key, encrypt);
        }

        public static string Cipher(string targetString, byte key, bool encrypt)
        {
            var chars = targetString.ToCharArray();
            var resultString = new StringBuilder();

            for (var i = 0; i < chars.Length; i++)
            {
                var bytes = GetUtf8Bytes(chars[i]);

                for (var j = 0; j < bytes.Length; j++)
                {
                    if (encrypt)
                        bytes[j] += key;
                    else
                        bytes[j] -= key;
                }

                var finalChar = GetStringFromUtf8(bytes);
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
            // Byte Order Mark . In short, the BOM is marker at the beginning of a file to indicate
            // if the most significant byte, or the least significant byte should come first.
        }
    }
}