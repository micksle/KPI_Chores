using System.Text;

namespace Lab4;

public class CaesarCipher
{
    // З'їв аґрусу — та ягода цілюща б'є жах інфекцій шипучим „ь“.
    // The five boxing wizards jump quickly
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
                Console.WriteLine(
                    "\t\t\tERROR\n\nMemory limit exceeded, seems like the choosen file was unpropriate, unable to use \"brute decription\" method");
                Console.WriteLine(e);
                return;
            }
        }

        FinalString = decryptedValue;

        if (positive)
            Console.WriteLine("Text decrypted succesfully, with the key value = " + (i - 1));
        else
            Console.WriteLine("Text decrypted succesfully, with the key value = " + (-i + 1));
    }
}