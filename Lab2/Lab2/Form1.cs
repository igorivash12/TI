using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frmMain : Form
    {
        const string space = "  ";
        byte[] bytesOfInitText;
        List<byte> bytesOfGenKey;
        byte[] bytesOfCypher;

        const int degree = 29;

        public frmMain()
        {
            InitializeComponent();

            openFileDialog1.Filter = "All files(*.*)|*.*";
            openFileDialog1.Title = "Выбор файла для загрузки";
            saveFileDialog1.Filter = "All files(*.*)|*.*";
            saveFileDialog1.Title = "Выбор файла для сохранения";
            saveFileDialog1.OverwritePrompt = true;
        }

        // Байты -> биты
        private string getBitsFromBytes(byte[] arrOfBytes)
        {
            string str = "";
            int i = 0;

            while (i < arrOfBytes.Length && i < 15)
            {
                str += Convert.ToString(arrOfBytes[i], 2).PadLeft(8, '0') + space;
                i++;
            }

            if (arrOfBytes.Length > 30)
            {
                str += "\n ... \n";
                i = arrOfBytes.Length - 15;
            }

            while (i < arrOfBytes.Length)
            {
                str += Convert.ToString(arrOfBytes[i], 2).PadLeft(8, '0') + space;
                i++;
            }

            return str;
        }

        // Проверка ключа
        private bool isRightKey()
        {
            string initKey = tbInitKey.Text;

            initKey = new string(initKey.Where(c => c == '1' || c == '0').ToArray());

            if (initKey.Length < degree)
            {
                MessageBox.Show(
                    "Ключ должен состоять из 29 символов (0 или 1).",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Генерация ключа (x^29 + x^2 + 1)
        private string generateKey(string initKey, int sizeOfGenKey)
        {
            byte[] register = new byte[degree];
            bytesOfGenKey = new List<byte>(sizeOfGenKey / 8);
            byte currByte = 0;

            // Инициализация регистра
            for (int i = 0; i < degree; i++)
                register[i] = (byte)Char.GetNumericValue(initKey[i]);

            byte resOfXOR;

            for (int i = 0; i < sizeOfGenKey; i++)
            {
                // x^29 + x^2 + 1
                resOfXOR = (byte)(register[0] ^ register[27]);

                currByte = (byte)(currByte << 1);
                currByte |= register[0];

                if ((i + 1) % 8 == 0)
                    bytesOfGenKey.Add(currByte);

                // Сдвиг
                Array.ConstrainedCopy(register, 1, register, 0, degree - 1);

                register[degree - 1] = resOfXOR;
            }

            return getBitsFromBytes(bytesOfGenKey.ToArray());
        }

        // XOR шифрование/дешифрование
        private string getResult(byte[] initText, byte[] key)
        {
            bytesOfCypher = new byte[initText.Length];

            for (int i = 0; i < initText.Length; i++)
            {
                bytesOfCypher[i] = (byte)(initText[i] ^ key[i]);
            }

            return getBitsFromBytes(bytesOfCypher);
        }

        // Сохранение файла
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel || bytesOfCypher == null)
                return;

            File.WriteAllBytes(saveFileDialog1.FileName, bytesOfCypher);
        }

        // Загрузка файла
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            tbGenKey.Text = "";
            tbCypherText.Text = "";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            bytesOfInitText = File.ReadAllBytes(openFileDialog1.FileName);
            tbInitFile.Text = getBitsFromBytes(bytesOfInitText);
        }

        // Шифрование
        private void btnCypher_Click(object sender, EventArgs e)
        {
            if (!isRightKey() || bytesOfInitText == null)
                return;

            tbGenKey.Text = generateKey(tbInitKey.Text, bytesOfInitText.Length * 8);
            tbCypherText.Text = getResult(bytesOfInitText, bytesOfGenKey.ToArray());
        }

        // Дешифрование
        private void btnEncypher_Click(object sender, EventArgs e)
        {
            if (!isRightKey() || bytesOfInitText == null)
                return;

            tbGenKey.Text = generateKey(tbInitKey.Text, bytesOfInitText.Length * 8);
            tbCypherText.Text = getResult(bytesOfInitText, bytesOfGenKey.ToArray());
        }

        // Очистка
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbInitFile.Text = "";
            tbGenKey.Text = "";
            tbCypherText.Text = "";
            tbInitKey.Text = "";
        }

        // Показ всех битов
        private void btnShowAllBytes_Click(object sender, EventArgs e)
        {
            if (bytesOfCypher == null || bytesOfInitText == null || bytesOfGenKey == null)
                return;

            StringBuilder str1 = new StringBuilder();
            StringBuilder str2 = new StringBuilder();
            StringBuilder str3 = new StringBuilder();

            for (int i = 0; i < bytesOfInitText.Length; i++)
            {
                str1.Append(Convert.ToString(bytesOfInitText[i], 2).PadLeft(8, '0') + space);
                str2.Append(Convert.ToString(bytesOfGenKey[i], 2).PadLeft(8, '0') + space);
                str3.Append(Convert.ToString(bytesOfCypher[i], 2).PadLeft(8, '0') + space);
            }

            tbInitFile.Text = str1.ToString();
            tbGenKey.Text = str2.ToString();
            tbCypherText.Text = str3.ToString();
        }
    }
}