using System;

namespace Cryptographic_system.Lab3.MainCode
{
    public class GammaCipher
    {
        public string FinalString;

        public void DoAction(string targetString, string seedValue, bool encrypt)
        {
            var seed = int.Parse(seedValue);
            FinalString = Gamma(targetString, seed, encrypt);
        }

        private static string Gamma(string targetString, int seed, bool encrypt)
        {
            var random = new Random(seed);
            var finalString = "";

            var gamma = new int[targetString.Length];
            for (var i = 0; i < gamma.Length; i++)
            {
                gamma[i] = random.Next(55295);
                finalString += (char)(targetString[i] ^ gamma[i]);
            }

            return finalString;
        }
    }
}