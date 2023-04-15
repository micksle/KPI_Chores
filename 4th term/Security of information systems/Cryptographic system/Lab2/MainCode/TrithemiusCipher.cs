using System.Windows.Forms;

namespace Cryptographic_system.Lab2.MainCode
{
    // Факт ґринджол: бій псюг вщух, з'їм шче яєць
    // The quick brown fox jumps over the lazy dog

    public class TrithemiusCipher
    {
        public string FinalString;
        private const int UnicodeMaxValue = 65536;

        public void DoAction(string targetString, string key1, string key2, string key3, string motto, State state,
            bool encrypt)
        {
            var a = int.Parse(key1);
            var b = int.Parse(key2);
            var c = int.Parse(key3);
            switch (state)
            {
                case State.LINEAR:
                    FinalString = Linear(targetString, a, b, encrypt);
                    break;
                case State.NONLINEAR:
                    FinalString = NonLinear(targetString, a, b, c, encrypt);
                    break;
                case State.MOTTO:
                    FinalString = Motto(targetString, motto, encrypt);
                    break;
                default:
                    MessageBox.Show(@"Some error occured!");
                    break;
            }
        }

        private string Linear(string targetString, int a, int b, bool encrypt)
        {
            var finalString = "";
            for (var i = 0; i < targetString.Length; i++)
            {
                var key = (a * i + b) % UnicodeMaxValue;

                int finalInt;
                if (encrypt)
                    finalInt = ((int)targetString[i] + key) % UnicodeMaxValue;
                else
                    finalInt = ((int)targetString[i] - key + UnicodeMaxValue) % UnicodeMaxValue;

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
                    finalChar = (char)(value - key);
                finalString += finalChar;
            }

            return finalString;
        }

        private string Alt(string targetString, int a, int b, int c, bool encrypt)
        {
            var finalString = "";
            for (var p = 0; p < targetString.Length; p++)
            {
                var key = (a * (p * p) + b * p + c) % UnicodeMaxValue;
                char finalChar;

                if (encrypt)
                    finalChar = (char) ((targetString[p] + key) % UnicodeMaxValue);
                else
                    finalChar = (char) ((targetString[p] - key + UnicodeMaxValue) % UnicodeMaxValue);

                finalString += finalChar;
            }

            return finalString;
        }

        private string Motto(string targetString, string motto, bool encrypt)
        {
            var result = "";
            var targetIndex = 0;

            foreach (var c in targetString)
            {
                var shift = char.ToUpper(motto[targetIndex]) - 'A' + 1;
                targetIndex = (targetIndex + 1) % motto.Length;

                var value = (int)c;

                if (encrypt)
                {
                    if (value >= 'A' && value <= 'Z')
                    {
                        value = 'A' + (value - 'A' + shift) % 26;
                    }
                    else if (value >= 'a' && value <= 'z')
                    {
                        value = 'a' + (value - 'a' + shift) % 26;
                    }
                    else if (value >= '0' && value <= '9')
                    {
                        value = '0' + (value - '0' + shift) % 10;
                    }
                }
                else
                {
                    if (value >= 'A' && value <= 'Z')
                    {
                        value = 'A' + (value - 'A' - shift + 26) % 26;
                    }
                    else if (value >= 'a' && value <= 'z')
                    {
                        value = 'a' + (value - 'a' - shift + 26) % 26;
                    }
                    else if (value >= '0' && value <= '9')
                    {
                        value = '0' + (value - '0' - shift + 10) % 10;
                    }
                }

                result += (char)value;
            }

            return result;
        }
    }
}