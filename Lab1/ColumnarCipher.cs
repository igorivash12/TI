using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class ColumnarCipher
    {
        private int[] GetKeyOrder(string key)
        {
            return key
                .Select((c, i) => new { Char = c, Index = i })
                .OrderBy(x => x.Char)
                .ThenBy(x => x.Index)
                .Select((x, i) => new { x.Index, Order = i })
                .OrderBy(x => x.Index)
                .Select(x => x.Order)
                .ToArray();
        }

        public string Encrypt(string text, string key)
        {
            int cols = key.Length;
            int rows = (int)Math.Ceiling((double)text.Length / cols);

            char[,] table = new char[rows, cols];

            int k = 0;

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    if (k < text.Length)
                        table[r, c] = text[k++];

            var order = GetKeyOrder(key);

            var result = new StringBuilder();

            for (int o = 0; o < cols; o++)
            {
                int colIndex = Array.IndexOf(order, o);

                for (int r = 0; r < rows; r++)
                {
                    if (table[r, colIndex] != '\0')
                        result.Append(table[r, colIndex]);
                }
            }

            return result.ToString();
        }

        public string Decrypt(string cipher, string key)
        {
            int cols = key.Length;
            int rows = (int)Math.Ceiling((double)cipher.Length / cols);

            char[,] table = new char[rows, cols];

            var order = GetKeyOrder(key);

            int fullCols = cipher.Length % cols;
            if (fullCols == 0) fullCols = cols;

            int index = 0;

            // заполняем столбцы правильно
            for (int o = 0; o < cols; o++)
            {
                int colIndex = Array.IndexOf(order, o);

                int currentColLength =
                    colIndex < fullCols ? rows : rows - 1;

                for (int r = 0; r < currentColLength; r++)
                {
                    table[r, colIndex] = cipher[index++];
                }
            }

            var result = new StringBuilder();

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    if (table[r, c] != '\0')
                        result.Append(table[r, c]);

            return result.ToString();
        }
    }
}
