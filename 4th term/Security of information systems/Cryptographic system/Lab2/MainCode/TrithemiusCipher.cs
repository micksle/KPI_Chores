using System.Windows.Forms;

namespace Cryptographic_system.Lab2.MainCode
{
    // Факт ґринджол: бій псюг вщух, з'їм шче яєць
    // The quick brown fox jumps over the lazy dog

    public class TrithemiusCipher
    {
        public string FinalString;
        private const int UnicodeMaxValue = 55295; // 65536;

        public void DoActio(string targetString, State state, bool encrypt, params string[] keys)
        {
            int a;
            int b;
            int c;
            switch (state)
            {
                case State.LINEAR:
                    a = int.Parse(keys[0]);
                    b = int.Parse(keys[1]);
                    FinalString = Equation(targetString, 0, a, b, encrypt);
                    break;
                case State.NONLINEAR:
                    a = int.Parse(keys[0]);
                    b = int.Parse(keys[1]);
                    c = int.Parse(keys[2]);
                    FinalString = Equation(targetString, a, b, c, encrypt);
                    break;
                case State.MOTTO:
                    FinalString = Motto(targetString, keys[0], encrypt);
                    break;
                default:
                    MessageBox.Show(@"Some error occured!");
                    break;
            }
        }

        public void DoAction(string targetString, string key1, string key2, string key3, string motto, State state,
            bool encrypt)
        {
            var a = int.Parse(key1);
            var b = int.Parse(key2);
            var c = int.Parse(key3);
            switch (state)
            {
                case State.LINEAR:
                    FinalString = Equation(targetString, 0, a, b, encrypt);
                    break;
                case State.NONLINEAR:
                    FinalString = Equation(targetString, a, b, c, encrypt);
                    break;
                case State.MOTTO:
                    FinalString = Motto(targetString, motto, encrypt);
                    break;
                default:
                    MessageBox.Show(@"Some error occured!");
                    break;
            }
        }

        private static string Equation(string targetString, int a, int b, int c, bool encrypt)
        {
            var finalString = "";
            for (var p = 0; p < targetString.Length; p++)
            {
                var key = (a * (p * p) + b * p + c) % UnicodeMaxValue;
                char finalChar;

                if (encrypt)
                {
                    finalChar = (char)((targetString[p] + key) % UnicodeMaxValue);
                    if (targetString[p] + key < 0)
                    {
                        finalChar = (char) (targetString[p] + key + UnicodeMaxValue);
                    } 
                }
                else
                    // finalChar = (char)((targetString[p] - (key % UnicodeMaxValue) + UnicodeMaxValue) % UnicodeMaxValue);
                    finalChar = (char)((targetString[p] - key + UnicodeMaxValue) % UnicodeMaxValue);

                finalString += finalChar;
            }

            return finalString;
        }

        private static string Motto(string targetString, string motto, bool encrypt)
        {
            while (motto.Length < targetString.Length)
                motto += motto;

            var finalString = "";
            for (var i = 0; i < targetString.Length; i++)
            {
                var targetInt = (int)targetString[i];
                var mottoInt = (int)motto[i];
                int finalInt;

                if (encrypt)
                {
                    finalInt = (targetInt + mottoInt) % char.MaxValue;
                }
                else
                {
                    finalInt = (targetInt - mottoInt) % char.MaxValue;
                    
                    if (targetInt - mottoInt == 0)
                        finalInt = targetInt;

                    if (finalInt < 0)
                    {
                        var temp = finalInt;
                        finalInt = temp + char.MaxValue;
                    }
                }

                finalString += char.ConvertFromUtf32(finalInt);
            }

            return finalString;
        }
    }
}