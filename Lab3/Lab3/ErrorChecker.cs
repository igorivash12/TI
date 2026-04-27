using System.Windows.Forms;

namespace Lab3
{
    public class ErrorChecker
    {
        public bool IsValidPrime(string str, string paramName)
        {
            if (!long.TryParse(str, out long val))
            {
                ShowError($"Некорректное значение {paramName}! Введите целое число.");
                return false;
            }

            if (val < 2)
            {
                ShowError($"Некорректное значение {paramName}! Число должно быть > 2.");
                return false;
            }

            if (!MathTools.IsPrime(val))
            {
                ShowError($"Некорректное значение {paramName}! Число должно быть простым.");
                return false;
            }

            return true;
        }

        public bool IsValidKO(string str, long phi)
        {
            if (!long.TryParse(str, out long val))
            {
                ShowError($"Некорректное значение KO! Введите целое число.");
                return false;
            }

            if (val < 2 || val >= phi)
            {
                ShowError($"Некорректное значение KO! KO должно быть в диапазоне [2, {phi - 1}].");
                return false;
            }

            if (!MathTools.IsRelativelyPrime(val, phi))
            {
                ShowError($"Некорректное значение KO! KO должно быть взаимно простым с φ(n) = {phi}.");
                return false;
            }

            return true;
        }

        public bool IsValidSourceData(byte[] data)
        {
            if (data == null || data.Length == 0)
            {
                ShowError($"Файл не выбран или пуст!");
                return false;
            }
            return true;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
