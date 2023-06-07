using System;
using System.Text;

namespace Cryptographic_system.Lab4.MainCode
{
    public class BookCipher
    {
        public string FinalString;
        private char[,] key;
        private const char baseSymbol = '%';

        public void DoAction(string targetString, string keyString, bool encrypt)
        {
            InitializeKey(keyString);
            if (encrypt)
                FinalString = Encrypt(targetString);
            else
                FinalString = Decrypt(targetString);
        }

        private void InitializeKey(string poem)
        {
            var lines = poem.Split('\n');
            var length = lines.Length;
            var numCols = 0;

            // Визначення максимальної кількості стовпчиків у ключі
            foreach (var line in lines)
            {
                if (line.Length > numCols)
                    numCols = line.Length;
            }

            key = new char[length, numCols];

            // Заповнення ключа символами вірша
            for (var i = 0; i < length; i++)
            {
                var line = lines[i];
                for (var j = 0; j < line.Length; j++)
                {
                    key[i, j] = line[j];
                }
            }
        }

        private char GetSymbol(int row, int col)
        {
            if (row >= 0 && row < key.GetLength(0) && col >= 0 && col < key.GetLength(1))
            {
                var symbol = key[row, col];
                if (symbol != '\n')
                    return symbol;
            }
            
            return baseSymbol;
        }

        private string Encrypt(string targetString)
        {
            var finalString = new StringBuilder();

            foreach (var c in targetString)
            {
                int row = -1, col = -1;

                // Пошук символу у ключі шифрування
                for (var i = 0; i < key.GetLength(0); i++)
                {
                    for (var j = 0; j < key.GetLength(1); j++)
                    {
                        if (key[i, j] == c)
                        {
                            row = i;
                            col = j;
                            break;
                        }
                    }

                    if (row != -1)
                        break;
                }

                // Додавання коду CС/SS до шифрограми
                finalString.Append($"{row:D2}/{col:D2}, ");
            }

            return finalString.ToString();
        }

        private string Decrypt(string targetString)
        {
            var finalString = new StringBuilder();

            var codes = targetString.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var code in codes)
            {
                var parts = code.Split('/');

                if (parts.Length == 2 && int.TryParse(parts[0], out var row) && int.TryParse(parts[1], out var col))
                {
                    var symbol = GetSymbol(row, col);

                    // Додавання символу до повідомлення
                    finalString.Append(symbol);
                }
            }

            return finalString.ToString();
        }
    }
}