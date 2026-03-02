using System;
using System.Linq;
using System.Text;

namespace Lab1
{
    public class VigenereCipher
    {
        const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        readonly string letters;

        public VigenereCipher(string alphabet = null)
        {
            letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
        }

        // Очистка строки: удаление всех символов вне алфавита
        private string CleanString(string input)
        {
            return new string(
                input
                    .ToUpper()
                    .Where(c => letters.Contains(c))
                    .ToArray()
            );
        }

        // Проверка ключа (без сообщений об ошибке)
        private bool IsValidKey(ref string key)
        {
            key = CleanString(key); // удаляем недопустимые символы

            return !string.IsNullOrEmpty(key);
        }

        private string Vigenere(string text, string key, bool encrypting = true)
        {
            var result = new StringBuilder();

            if (!IsValidKey(ref key))
                return result.ToString(); // просто вернуть пустую строку

            text = CleanString(text); // очищаем текст полностью

            int q = letters.Length;

            for (int i = 0; i < text.Length; i++)
            {
                int letterIndex = letters.IndexOf(text[i]);

                char keyChar;

                if (i < key.Length)
                {
                    keyChar = key[i];
                }
                else
                {
                    if (encrypting)
                        keyChar = text[i - key.Length];      // автоключ из открытого текста
                    else
                        keyChar = result[i - key.Length];    // автоключ из расшифрованного текста
                }

                int codeIndex = letters.IndexOf(keyChar);

                int shift = encrypting ? codeIndex : -codeIndex;
                int newIndex = (q + letterIndex + shift) % q;

                result.Append(letters[newIndex]);
            }

            return result.ToString(); // всегда сплошная строка
        }

        public string Encrypt(string plainMessage, string password)
            => Vigenere(plainMessage, password);

        public string Decrypt(string encryptedMessage, string password)
            => Vigenere(encryptedMessage, password, false);
    }
}