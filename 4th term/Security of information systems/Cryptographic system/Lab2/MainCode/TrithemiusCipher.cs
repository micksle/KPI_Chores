using System.Windows.Forms;

namespace Cryptographic_system.Lab2.MainCode
{
    // З'їв аґрусу — та ягода цілюща б'є жах інфекцій шипучим „ь“.
    // The five boxing wizards jump quickly

    public class TrithemiusCipher
    {
        public string FinalString;

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
                    MessageBox.Show("Some error occured!    ");
                    break;
            }
        }

        private string Linear(string targetString, int a, int b, bool encrypt)
        {
            var finalString = "";
            for (var i = 0; i < targetString.Length; i++)
            {
                var key = (a * i + b) % 1112064; //65536;

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
                    finalChar = (char)(value - key);
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

                var code = (int)c;

                if (encrypt)
                {
                    if (code >= 'A' && code <= 'Z')
                    {
                        code = 'A' + (code - 'A' + shift) % 26;
                    }
                    else if (code >= 'a' && code <= 'z')
                    {
                        code = 'a' + (code - 'a' + shift) % 26;
                    }
                    else if (code >= '0' && code <= '9')
                    {
                        code = '0' + (code - '0' + shift) % 10;
                    }
                }
                else
                {
                    if (code >= 'A' && code <= 'Z')
                    {
                        code = 'A' + (code - 'A' - shift + 26) % 26;
                    }
                    else if (code >= 'a' && code <= 'z')
                    {
                        code = 'a' + (code - 'a' - shift + 26) % 26;
                    }
                    else if (code >= '0' && code <= '9')
                    {
                        code = '0' + (code - '0' - shift + 10) % 10;
                    }
                }

                result += (char)code;
            }

            return result;
        }
    }
}