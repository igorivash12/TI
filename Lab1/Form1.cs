using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string VigenerEncryption(string text, string key)
        {
            var cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            text = text.ToUpper();
            key = key.ToUpper();
            string cipherText = cipher.Encrypt(text, key);
            return cipherText;
        }

        private string VigenerDencryption(string text, string key)
        {
            var cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            text = text.ToUpper();
            key = key.ToUpper();
            string cipherText = cipher.Decrypt(text, key);
            return cipherText;
        }

        private string ColumnarEncryption(string text, string key)
        {
            var cipher = new ColumnarCipher();
            text = text.ToUpper();
            key = key.ToUpper();
            string cipherText = cipher.Encrypt(text, key);
            return cipherText;
        }

        private string ColumnarDecryption(string text, string key)
        {
            var cipher = new ColumnarCipher();
            text = text.ToUpper();
            key = key.ToUpper();
            string cipherText = cipher.Decrypt(text, key);
            return cipherText;
        }

        // ----------------------------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPlainText.Text = string.Empty;
            tbCipherText.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTypesOfCipher.SelectedIndex = 0;
        }

        private void btnCipher_Click(object sender, EventArgs e)
        {
            if (cmbTypesOfCipher.SelectedIndex == 0)
            {   
                tbCipherText.Text = VigenerEncryption(tbPlainText.Text, tbKey.Text);
            }
            else if (cmbTypesOfCipher.SelectedIndex == 1)
            {
                if (cbAdvanced.Checked == true)
                {
                    tbCipherText.Text = ColumnarEncryption(tbPlainText.Text, tbKey.Text);
                    tbCipherText.Text = ColumnarEncryption(tbPlainText.Text, tbKey2.Text);
                }
                else
                {
                    tbCipherText.Text = ColumnarEncryption(tbPlainText.Text, tbKey.Text);
                }
            }
        }

        private void btnDecipher_Click(object sender, EventArgs e)
        {
            if (cmbTypesOfCipher.SelectedIndex == 0)
            {
                tbCipherText.Text = VigenerDencryption(tbPlainText.Text, tbKey.Text);
            }
            else if ( cmbTypesOfCipher.SelectedIndex == 1)
            {
                if(cbAdvanced.Checked == true)
                {
                    tbCipherText.Text = ColumnarDecryption(tbPlainText.Text, tbKey.Text);
                    tbCipherText.Text = ColumnarDecryption(tbPlainText.Text, tbKey2.Text);
                }
                else
                {
                    tbCipherText.Text = ColumnarDecryption(tbPlainText.Text, tbKey.Text);
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                tbPlainText.Text = File.ReadAllText(ofd.FileName, Encoding.UTF8);
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, tbCipherText.Text, Encoding.UTF8);
        }

        private void cmbTypesOfCipher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypesOfCipher.SelectedIndex == 1)
            {
                cbAdvanced.Visible = true;
            } else 
            { 
                cbAdvanced.Visible = false;
                cbAdvanced.Checked = false;
            }
        }

        private void cbAdvanced_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbAdvanced.Checked == true)
            { 
                tbKey2.Visible = true;
                lblKey2.Visible = true;
            }
            else
            {
                tbKey2.Visible = false;
                lblKey2.Visible = false;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            tbPlainText.Text = tbCipherText.Text;
            tbCipherText.Clear();
        }
    }
}
