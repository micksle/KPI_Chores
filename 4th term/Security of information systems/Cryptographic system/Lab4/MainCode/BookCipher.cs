using System;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cryptographic_system.Lab4.MainCode
{
    public class BookCipher
    {
        public string FinalString;
        private char[,] keyMatrix;
        private const char baseSymbol = '%';

        public void DoAction(string targetString, string keyString, bool encrypt)
        {
            FillKey(keyString);
            FinalString = encrypt ? Encrypt(targetString) : Decrypt(targetString);
        }

        private void FillKey(string poem)
        {
            var row = poem.Split('\n');
            var rowLength = row.Length;
            var colsLength = 0;

            foreach (var line in row)
            {
                if (line.Length > colsLength)
                    colsLength = line.Length;
            }

            keyMatrix = new char[rowLength, colsLength];

            // Заповнення ключа символами вірша
            for (var i = 0; i < rowLength; i++)
            {
                var line = row[i];
                for (var j = 0; j < line.Length; j++)
                {
                    keyMatrix[i, j] = line[j];
                }
            }
        }

        private char GetSymbol(int row, int col)
        {
            if (row >= 0 && row < keyMatrix.GetLength(0) && col >= 0 && col < keyMatrix.GetLength(1))
            {
                var symbol = keyMatrix[row, col];
                if (symbol != '\n')
                    return symbol;
            }

            return baseSymbol;
        }

            private string Encrypt(string targetString)
        {
            var finalString = new StringBuilder();
            var error = new StringBuilder();
            error.Append("\t\t\tError!\nThe specified characters: ");
            var random = new Random();

            foreach (var c in targetString)
            {
                int row, col;

                // Пошук символу у ключі шифрування
                var positions = new List<Tuple<int, int>>();
                for (var i = 0; i < keyMatrix.GetLength(0); i++)
                {
                    for (var j = 0; j < keyMatrix.GetLength(1); j++)
                    {
                        if (keyMatrix[i, j] == c)
                        {
                            positions.Add(Tuple.Create(i, j));
                        }
                    }
                }

                if (positions.Count > 0)
                {
                    var randomPosition = positions[random.Next(0, positions.Count)];
                    row = randomPosition.Item1;
                    col = randomPosition.Item2;
                }
                else
                {
                    row = -1;
                    col = -1;
                    error.Append(c + ", ");
                }

                finalString.Append($"{row:D2}/{col:D2}, ");
            }

            error.Append("is not found, it is replaced with the standard character [%]");
            MessageBox.Show(error.ToString());

            return finalString.ToString();
        }


        private string Decrypt(string targetString)
        {
            var rows = targetString.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var finalString = new StringBuilder();

            foreach (var position in rows)
            {
                var parts = position.Split('/');

                if (parts.Length == 2 && int.TryParse(parts[0], out var row) && int.TryParse(parts[1], out var col))
                {
                    var symbol = GetSymbol(row, col);
                    finalString.Append(symbol);
                }
            }

            return finalString.ToString();
        }
    }
}