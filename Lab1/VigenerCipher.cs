using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private bool IsValidKey(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Ключ не может быть пустым!");
                return false;
            }

            char invalidChar = key.FirstOrDefault(c => !letters.Contains(c));

            if (invalidChar != default(char))
            {
                MessageBox.Show($"'{invalidChar}' - недопустимый символ в ключе!");
                return false;
            }
            return true;
        }

        //генерация повторяющегося пароля
        private string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }

            return p.Substring(0, n);
        }

        private string Vigenere(string text, string key, bool encrypting = true)
        {
            var result = new StringBuilder();
            if (IsValidKey(key))
            {
                var longKey = GetRepeatKey(key, text.Length);                
                var q = letters.Length;

                for (int i = 0; i < text.Length; i++)
                {
                    var letterIndex = letters.IndexOf(text[i]);
                    var codeIndex = letters.IndexOf(longKey[i]);

                    if (letterIndex < 0)
                    {
                        result.Append(text[i]);
                    }
                    else
                    {
                        int shift = encrypting ? codeIndex : -codeIndex;
                        int newIndex = (q + letterIndex + shift) % q;
                        result.Append(letters[newIndex]);
                    }
                }                
            }
            return result.ToString();
        }

        //шифрование текста
        public string Encrypt(string plainMessage, string password)
            => Vigenere(plainMessage, password);

        //дешифрование текста
        public string Decrypt(string encryptedMessage, string password)
            => Vigenere(encryptedMessage, password, false);
    }
}
