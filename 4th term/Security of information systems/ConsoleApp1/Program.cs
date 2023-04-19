// namespace Lab4
// {
//     public class smt
//     {
//         public static void Main()
//         {
//             int[] k = { 13, 10978 };  // задаємо ключ (A = 3, B = 7)
//             TritemiusCipher cipher = new TritemiusCipher(k);
//
//             string message = "The quick brown fox jumps over the lazy dog";
//             Console.WriteLine("Повідомлення: " + message);
//
//             string encryptedMessage = cipher.Linear(message, true);
//             Console.WriteLine("Зашифроване повідомлення: " + encryptedMessage);
//
//             string decryptedMessage = cipher.Linear(message, false);
//             Console.WriteLine("Розшифроване повідомлення: " + decryptedMessage);
//
//             Console.WriteLine("\n\n" + "\n\n--");
//
//             // var key = -120;
//             // var targetString = "The five boxing wizards jump quickly";
//             // foreach (var s in targetString)
//             // {
//             //     var initialInt = (int)s;
//             //     // Console.Write("|   " + initialInt);
//             //     var finalInt = initialInt + key;
//             //     Console.WriteLine($"{initialInt}     |     {finalInt}");
//             // }
//             //
//             // Console.WriteLine("\n\n------------------------------------------------");
//             // CaesarCipher cs = new CaesarCipher();
//             // cs.DoAction("З'їв аґрусу — та ягода цілюща б'є жах інфекцій шипучим „ь“ The five boxing wizards jump quickly",
//             //     "-120", true);
//             // Console.WriteLine(cs.FinalString);
//             // cs.DoAction(cs.FinalString,
//             //     "-120", false);
//             // Console.WriteLine(cs.FinalString);
//         }
//
//     }
// }


using System;

class Program
{
    static void Main()
    {
        var UnicodeMaxValue = 55295;
        var encrypt = true;
        var final = "";
        var target = "Щастям б'єш жук їх глицю в фон й ґедзь прічThe quick brown fox jumps over the lazy dog";
        var a = 0;
        var b = -1200;
        var c = 30;

        for (var p = 0; p < target.Length; p++)
        {
            var key = (a * (p * p) + b * p + c) % UnicodeMaxValue;

            if (p == target.Length - 1)
            {
                Console.WriteLine(target[p]);
                Console.Write("key " + key+ "  : ");

            }
            char finalChar;

            if (encrypt)
            {
                if (p == target.Length - 1)
                {
                 
                    Console.WriteLine("final char before " + (target[p] + key));
                    Console.Write(((target[p] + key) % UnicodeMaxValue) + "  |\n ");   
                }
                finalChar = (char)((target[p] + key) % UnicodeMaxValue);   
                
            }
            else
            {
                var value = (target[p] - key + UnicodeMaxValue) % UnicodeMaxValue;
                Console.Write(value + "  | ");
                // finalChar = (char)((targetString[p] - (key % UnicodeMaxValue) + UnicodeMaxValue) % UnicodeMaxValue);
                finalChar = (char)((target[p] - key + UnicodeMaxValue) % UnicodeMaxValue);

            }


            if (p == target.Length - 1)
            {
                Console.WriteLine(finalChar);
                Console.WriteLine((int) finalChar);
                
            }


            if (encrypt)
            {
                if (target[p] + key < 0)
                {
                    finalChar = (char) (target[p] + key + UnicodeMaxValue);
                } 
            }
            
            
            
            
            final += finalChar;
        }

        
        
        
        
        
        Console.WriteLine("\n\n\t" + final + "sent");
        
        Console.WriteLine("\n\n_____________________________________");
        
        
        // var targetString = "Щастям б'єш жук їх глицю в фон й ґедзь пріч The quick brown fox jumps over the lazy dog";
        // var motto = "The quick brown fox jumps over the lazy dog";
        //
        // while (motto.Length < targetString.Length)
        //     motto += motto;
        //
        // var finalString = "";
        // for (var i = 0; i < targetString.Length; i++)
        // {
        //     var targetInt = (int)targetString[i];
        //     var mottoInt = (int)motto[i];
        //     int finalInt;
        //
        //     Console.WriteLine(" " + targetInt + "  |  " + mottoInt);
        //
        //     finalInt = (targetInt - mottoInt) % char.MaxValue; // дізнатись як поводить з мінусом
        //     Console.Write("value " + finalInt + "\n");
        //
        //     if (targetInt - mottoInt == 0)
        //     {
        //         finalInt = targetInt;
        //     }
        //     
        //     if (finalInt < 0)
        //     {
        //         var temp = finalInt;
        //         finalInt = temp + char.MaxValue;
        //     }
        //
        //     finalString += char.ConvertFromUtf32(finalInt);
        //     // finalString += (char)finalInt;
        // }
        //
        //
        // Console.WriteLine("\n\n-----------_________________----------");
        //
        //
        // Console.WriteLine(char.MaxValue + "  max");
        // // Введення рядка, який будемо шифрувати
        // Console.Write("Введіть рядок для шифрування: ");
        // string plaintext = Console.ReadLine();
        //
        // // Введення гасла
        // Console.Write("Введіть гасло: ");
        // string password = Console.ReadLine();
        //
        // // Повторення гасла, якщо воно коротше за розмір рядка
        // while (password.Length < plaintext.Length)
        // {
        //     password += password;
        // }
        //
        // // Шифрування рядка
        // string ciphertext = "";
        // for (int i = 0; i < plaintext.Length; i++)
        // {
        //     // Обчислення номера символу рядка та гасла
        //     int plainchar = (int)plaintext[i];
        //     int passwordchar = (int)password[i];
        //
        //     // Обчислення номера зашифрованого символу
        //     int cipherchar = (plainchar + passwordchar) % char.MaxValue;
        //
        //     // Додавання зашифрованого символу до результуючого рядка
        //     ciphertext += Char.ConvertFromUtf32(cipherchar);
        // }
        //
        // // Виведення зашифрованого рядка
        // Console.WriteLine("Зашифрований рядок: {0}", ciphertext);
        //
        // // Розшифрування рядка
        // string decryptedtext = "";
        // for (int i = 0; i < ciphertext.Length; i++)
        // {
        //     // Обчислення номера символу гасла
        //     int passwordchar = (int)password[i];
        //
        //     // Обчислення номера розшифрованого символу
        //     int decryptedchar = (int)ciphertext[i] - passwordchar;
        //     if (decryptedchar < 0)
        //     {
        //         decryptedchar += char.MaxValue;
        //     }
        //
        //     // Додавання розшифрованого символу до результуючого рядка
        //     decryptedtext += Char.ConvertFromUtf32(decryptedchar);
        // }
        //
        // // Виведення розшифрованого рядка
        // Console.WriteLine("Розшифрований рядок: {0}", decryptedtext);
    }
}