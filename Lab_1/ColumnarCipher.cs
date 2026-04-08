using System;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab1
{
    public class ColumnarCipher
    {
        private readonly string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private string Clean(string text)
        {
            text = text.ToUpper();
            StringBuilder result = new StringBuilder();
            foreach (char c in text)
            {
                if (alphabet.IndexOf(c) >= 0)
                    result.Append(c);
            }
            return result.ToString();
        }

        // order[j] = номер (1-based) для j-го столбца ключа
        private int[] GetKeyOrder(string key)
        {
            int n = key.Length;
            int[] order = new int[n];
            bool[] used = new bool[n];

            for (int i = 0; i < n; i++)
            {
                char min = (char)('Z' + 1);
                int index = -1;
                for (int j = 0; j < n; j++)
                {
                    if (!used[j] && key[j] < min)
                    {
                        min = key[j];
                        index = j;
                    }
                }
                used[index] = true;
                order[index] = i + 1;
            }
            return order;
        }

        // Длина строки r определяется циклически: строка r ведёт себя как строка (r % cols).
        // Длина = индекс столбца, у которого order == (r % cols + 1), плюс 1.
        private int GetRowLength(int[] order, int r)
        {
            int cols = order.Length;
            int target = (r % cols) + 1;
            for (int j = 0; j < cols; j++)
            {
                if (order[j] == target)
                    return j + 1;
            }
            return 0;
        }

        public string Encrypt(string text, string key)
        {
            text = Clean(text);
            key = Clean(key);
            if (key.Length == 0)
            {
                MessageBox.Show("Ключ должен содержать английские буквы!");
                return "";
            }
            
            if (text.Length == 0)
            {
                MessageBox.Show("Текст не содержит английских букв!");
                return "";
            }

            int cols = key.Length;
            int[] order = GetKeyOrder(key);

            // Считаем сколько строк нужно, чтобы вместить весь текст
            int numRows = 0;
            int totalCells = 0;
            while (totalCells < text.Length)
            {
                totalCells += GetRowLength(order, numRows);
                numRows++;
            }

            // Заполняем таблицу построчно
            char[,] table = new char[numRows, cols];
            int index = 0;
            for (int r = 0; r < numRows; r++)
            {
                int rowLen = GetRowLength(order, r);
                for (int c = 0; c < rowLen && index < text.Length; c++)
                {
                    table[r, c] = text[index++];
                }
            }

            // Считываем по столбцам в порядке ключа
            StringBuilder cipher = new StringBuilder();
            for (int num = 1; num <= cols; num++)
            {
                int col = -1;
                for (int j = 0; j < cols; j++)
                {
                    if (order[j] == num) { col = j; break; }
                }
                for (int r = 0; r < numRows; r++)
                {
                    int rowLen = GetRowLength(order, r);
                    if (col < rowLen && table[r, col] != '\0')
                        cipher.Append(table[r, col]);
                }
            }
            return cipher.ToString();
        }

        public string Decrypt(string cipher, string key)
        {
            cipher = Clean(cipher);
            key = Clean(key);
            if (key.Length == 0)
            {
                MessageBox.Show("Ключ должен содержать английские буквы!");
                return "";
            }

            if (cipher.Length == 0)
            {
                MessageBox.Show("Текст не содержит английских букв!");
                return "";
            }

            int cols = key.Length;
            int[] order = GetKeyOrder(key);

            // Вычисляем фактическую длину каждой строки:
            // строки заполняются последовательно до своей максимальной длины,
            // последняя строка может быть обрезана
            int[] actualRowLen = new int[cipher.Length]; // максимум столько строк
            int remaining = cipher.Length;
            int numRows = 0;
            while (remaining > 0)
            {
                int maxLen = GetRowLength(order, numRows);
                int take = Math.Min(maxLen, remaining);
                actualRowLen[numRows] = take;
                remaining -= take;
                numRows++;
            }

            // Заполняем таблицу по столбцам в порядке ключа.
            // В столбец col попадают только строки r, у которых actualRowLen[r] > col
            char[,] table = new char[numRows, cols];
            int idx = 0;
            for (int num = 1; num <= cols; num++)
            {
                int col = -1;
                for (int j = 0; j < cols; j++)
                {
                    if (order[j] == num) { col = j; break; }
                }
                for (int r = 0; r < numRows; r++)
                {
                    if (actualRowLen[r] > col && idx < cipher.Length)
                        table[r, col] = cipher[idx++];
                }
            }

            // Читаем таблицу построчно
            StringBuilder result = new StringBuilder();
            for (int r = 0; r < numRows; r++)
            {
                for (int c = 0; c < actualRowLen[r]; c++)
                {
                    if (table[r, c] != '\0')
                        result.Append(table[r, c]);
                }
            }
            return result.ToString();
        }
    }
}