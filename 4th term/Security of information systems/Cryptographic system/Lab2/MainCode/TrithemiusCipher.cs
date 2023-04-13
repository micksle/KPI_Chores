namespace Cryptographic_system.Lab2.MainCode
{
    // З'їв аґрусу — та ягода цілюща б'є жах інфекцій шипучим „ь“.
    // The five boxing wizards jump quickly

    public class TrithemiusCipher
    {
        public string FinalString;

        public void DoAction(string targetString, string key1, string key2, string key3, int cipherOption, bool encrypt)
        {
            var a = int.Parse(key1);
            var b = int.Parse(key2);
            var c = int.Parse(key3);
            switch (cipherOption)
            {
                case 1:
                    FinalString = Linear(targetString, a, b, encrypt);
                    break;
                case 2:
                    FinalString = NonLinear(targetString, a, b, c, encrypt);
                    break;
                // case 3:
                //     FinalString = Slogan(targetString, a, b, encrypt);
                //     break;
            }
        }

        private string Linear(string targetString, int a, int b, bool encrypt)
        {
            
            var finalString = "";
            for (var i = 0; i < targetString.Length; i++)
            {
                var key = (a * i + b) % 1112064;         //65536;

                int finalInt;
                if (encrypt)
                {
                    finalInt = ((int)targetString[i] + key) % 1112064;
                }
                else
                {
                    finalInt = ((int)targetString[i] - key + 1112064) % 1112064;
                }
                var finalChar = (char)finalInt;
                finalString += finalChar;
            }

            return finalString;
        }

        private string NonLinear(string targetString, int a, int b, int c, bool encrypt)
        {
            var finalString = "";
            var p = 0;

            foreach (var value in targetString)
            {
                p++;
                var key = a * (p * p) + b * p + c;
                char finalChar;
                
                if (encrypt)
                    finalChar = (char)(value + key);
                else
                    finalChar =  (char)(value - key);
                finalString += finalChar;
            }

            return finalString;
        }

        // public string Slogan(string targetString, string slogan, bool encrypt)
        // {
        //     var finalString = new StringBuilder();
        //
        //     foreach (var u in targetString)
        //     {
        //         var initialInt = (int)u;
        //         int finalInt;
        //
        //         var step = a * initialInt * initialInt + b * initialInt + c;
        //         
        //         if (encrypt)
        //             finalInt = (initialInt + step) % 65536;
        //         else
        //             finalInt = (initialInt - step % 65536 + 65536) % 65536;
        //
        //         var finalChar = (char)finalInt;
        //         finalString.Append(finalChar);
        //     }
        //
        //     return finalString.ToString();
        // }
    }
}